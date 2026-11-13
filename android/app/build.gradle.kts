plugins {
    id("com.android.application")
    id("org.jetbrains.kotlin.android")
}

// The CI workflow writes the signing key from the GitHub Secret
// ANDROID_KEYSTORE_B64 into this file before building, so every build is
// signed with the SAME key and new versions install over old ones without
// uninstalling. The key and its password are never stored in the repository.
// Local builds without the key fall back to debug signing.
val releaseKeystore = rootProject.file("rc-ranya.jks")
val keystorePassword = System.getenv("ANDROID_KEYSTORE_PASSWORD") ?: ""

android {
    namespace = "edu.uor.remco"
    compileSdk = 34

    defaultConfig {
        applicationId = "edu.uor.remco"
        minSdk = 26
        targetSdk = 34
        versionCode = (System.getenv("GITHUB_RUN_NUMBER") ?: "1").toInt()
        versionName = "1.0." + (System.getenv("GITHUB_RUN_NUMBER") ?: "0")
    }

    signingConfigs {
        if (releaseKeystore.exists()) {
            create("uor") {
                storeFile = releaseKeystore
                storePassword = keystorePassword
                keyAlias = "rc-ranya"
                keyPassword = keystorePassword
            }
        }
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            signingConfig = if (releaseKeystore.exists())
                signingConfigs.getByName("uor") else signingConfigs.getByName("debug")
        }
    }

    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_17
        targetCompatibility = JavaVersion.VERSION_17
    }
    kotlinOptions {
        jvmTarget = "17"
    }
    lint {
        checkReleaseBuilds = false
        abortOnError = false
    }
}

dependencies {
}
