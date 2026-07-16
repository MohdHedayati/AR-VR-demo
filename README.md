# 🏎️ F1 AR Spawner

## Overview
This project is an Augmented Reality (AR) Android application built with Unity 6 and ARCore. It allows users to detect flat physical surfaces (like desks or floors) through their phone's camera and spawn a digital Formula 1 car directly into the real world. 

This repository serves as the foundational base for the project, configured with the Universal Render Pipeline (URP) and AR Foundation, ready for the team to expand upon.

## ✨ Current Features
* **AR Plane Detection:** Utilizes ARCore to scan and identify horizontal surfaces in real-time.
* **1:2 Scale Model Spawning:** Accurately drops a scaled F1 car prefab onto the detected plane via a screen tap.
* **Optimized URP Rendering:** Configured with a custom AR Background Renderer Feature to seamlessly composite the physical camera feed with the digital 3D environment, removing default skyboxes.

## 🛠️ Tech Stack
* **Game Engine:** Unity 6
* **Language:** C#
* **AR Framework:** AR Foundation (Google ARCore)
* **Graphics:** Universal Render Pipeline (URP)
