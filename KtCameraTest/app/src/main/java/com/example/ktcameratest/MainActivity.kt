package com.example.ktcameratest

import android.Manifest
import android.graphics.Bitmap
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.WindowInsets
import androidx.compose.foundation.layout.asPaddingValues
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.systemBars
import androidx.compose.material3.Surface
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import com.example.ktcameratest.ui.theme.KtCameraTestTheme


class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        requestPermissions(arrayOf(Manifest.permission.CAMERA), 0)

        enableEdgeToEdge()
        setContent {
            KtCameraTestTheme {
                // 讓系統 UI（狀態列/導覽列）不擋住內容
                Surface(
                    modifier = Modifier
                        .fillMaxSize()
                        .padding(WindowInsets.systemBars.asPaddingValues())
                ) {
                    var bitmap by remember { mutableStateOf<Bitmap?>(null) }

                    if (bitmap == null) {
                        CameraCaptureScreen(
                            onImageCaptured = { bmp -> bitmap = bmp })
                    } else {
                        CapturedImageScreen(bitmap = bitmap!!)
                    }
                }
            }
        }

    }
}

