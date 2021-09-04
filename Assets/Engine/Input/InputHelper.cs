﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SS3D.Engine.Input {
    public class InputHelper : MonoBehaviour
    {

        public static InputActions inp { get; } = new InputActions();

        static InputHelper()
        {


            string bindings = PlayerPrefs.GetString("bindings", null);
            if (bindings != null)
            {
                InputHelper.inp.LoadBindingOverridesFromJson(bindings);
            }
            inp.Enable();
        }

        public static Vector3 GetPointerWorldPos()
        {
            return Camera.current.ScreenToWorldPoint(inp.Pointer.Position.ReadValue<Vector2>());
        }
    }
}