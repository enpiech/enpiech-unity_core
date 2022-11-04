﻿using NaughtyAttributes;
using UnityEngine;

namespace Enpiech.Core.Runtime
{
    [RequireComponent(typeof(SpriteRenderer))]
    public sealed class FullscreenSprite : MonoBehaviour
    {
        private void Awake()
        {
            ScaleToFullScreen();
        }

        [Button]
        private void ScaleToFullScreen()
        {
            transform.localScale = Vector3.one;
            var spriteRenderer = GetComponent<SpriteRenderer>();

            var cameraHeight = Camera.main.orthographicSize * 2;
            var cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
            Vector2 spriteSize = spriteRenderer.sprite.bounds.size;

            Vector2 scale = transform.localScale;
            if (cameraSize.x >= cameraSize.y)
            {
                // Landscape (or equal)
                scale *= cameraSize.x / spriteSize.x;
            }
            else
            {
                // Portrait
                scale *= cameraSize.y / spriteSize.y;
            }

            transform.position = Vector2.zero; // Optional
            transform.localScale = scale;
        }
    }
}