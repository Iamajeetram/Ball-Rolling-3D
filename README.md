# 🏀 Ball Rolling Game

<div align="center">

![Unity](https://img.shields.io/badge/Unity-2022.3-000000?style=for-the-badge&logo=data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjQiIGhlaWdodD0iMjQiIHZpZXdCb3g9IjAgMCAyNCAyNCIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4KPHBhdGggZD0iTTEyIDBMMTggMTJMMTIgMjRMNiAxMkwxMiAwWiIgZmlsbD0iY3VycmVudENvbG9yIi8+Cjwvc3ZnPgo=)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20Unity%20Editor-green?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)

**🎯 A thrilling 3D endless runner where physics meets fun!**

*Roll fast, collect coins, avoid obstacles - How far can you go?*

![Game Screenshot](Screenshots/gameplay-screenshot.png)

[![Download APK](https://img.shields.io/badge/📱_DOWNLOAD_APK-4ECDC4?style=for-the-badge&logoColor=white)](./Releases/BallRolling-v1.0.apk)
[![Unity Project](https://img.shields.io/badge/🎮_UNITY_PROJECT-FF6B6B?style=for-the-badge&logoColor=white)](./Assets/)

</div>

---

## ✨ Features

<table>
<tr>
<td width="50%">

### 🎮 **Gameplay**
- 🏃‍♂️ **Endless Runner** - Infinite procedurally generated roads
- ⚡ **Physics-Based** - Realistic ball movement with Unity Rigidbody
- 🪙 **Coin Collection** - Gather coins to unlock customizations
- 🎯 **High Scores** - Beat your personal best distance
- 💥 **Dynamic Obstacles** - Test your reflexes and timing

</td>
<td width="50%">

### 🎨 **Visual & Audio**
- ✨ **Glowing Effects** - Customizable emission materials
- 🎵 **Immersive Audio** - Sound effects for every action
- 📱 **Mobile Optimized** - Smooth 60fps on mobile devices
- 🎥 **Cinematic Camera** - Dynamic following system
- 🌈 **Color Customization** - Multiple ball themes to unlock

</td>
</tr>
</table>

---

## 🕹️ Controls

<div align="center">

| Platform | Control | How to Play |
|:--------:|:-------:|:-----------:|
| 📱 **Android Device** | Touch Controls | Download APK → Install → Play |
| 🎮 **PC (Unity Editor)** | Arrow Keys | Open Project → Press Play |

</div>

---

## 🎯 How to Play

> **Objective:** Roll as far as possible while collecting coins and avoiding obstacles!

```
🎮 GAMEPLAY FLOW
│
├── 🏁 Start Rolling
├── ⬅️➡️ Navigate Left/Right  
├── 🪙 Collect Coins (+Points)
├── 🚧 Avoid Obstacles
├── 📏 Distance = Score
└── 🏆 Beat High Score!
```

### 💀 Game Over Conditions
- 💥 **Collision** with obstacles
- 🏃‍♂️ **Fall Off** the road (too far left/right)

---

## 🛍️ Shop System

<div align="center">

**💰 Spend your collected coins wisely!**

| Feature | Description |
|:-------:|:-----------:|
| 🎨 **Color Themes** | Unlock vibrant glowing ball colors |
| ✨ **Emission Effects** | Customize your ball's glow intensity |
| 🔐 **Persistent Unlocks** | Keep your purchases forever |
| 🎯 **Active Selection** | Choose your favorite style |

</div>

---

## 🛠️ Technical Highlights

<div align="center">

### 🔧 **Built with Modern Unity Practices**

</div>

| Component | Technology | Purpose |
|:---------:|:----------:|:-------:|
| ⚙️ **Movement System** | Unity Physics | Realistic ball dynamics |
| 🎵 **Audio Manager** | Singleton Pattern | Consistent sound experience |
| 📷 **Camera System** | LateUpdate Tracking | Smooth following |
| 🏗️ **Road Generation** | Procedural System | Infinite world creation |
| 💾 **Save System** | PlayerPrefs | Persistent progress |
| 📱 **Touch Controls** | Event System | Mobile-friendly input |

---

## 🎮 Game Stats Dashboard

<div align="center">

**📊 Real-time performance metrics**

🏃‍♂️ **Speed Display** | 📏 **Distance Tracking** | 🪙 **Coin Counter** | 🏆 **High Score**
:---: | :---: | :---: | :---:
Live KM/H readout | Real-time score updates | Session & total coins | Personal best record

</div>

---

## 🚀 Platform Support

<div align="center">

### 📱 **Primary Platform: Android**
[![Android](https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white)](./Releases/BallRolling-v1.0.apk)
[![Min SDK](https://img.shields.io/badge/Min%20SDK-21-green?style=for-the-badge)](#)
[![Target SDK](https://img.shields.io/badge/Target%20SDK-33-blue?style=for-the-badge)](#)

### 🎮 **Development Platform: Unity Editor**
[![Unity](https://img.shields.io/badge/Unity%20Editor-000000?style=for-the-badge&logo=unity&logoColor=white)](#)
[![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)](#)
[![Mac](https://img.shields.io/badge/Mac-000000?style=for-the-badge&logo=apple&logoColor=white)](#)

</div>

---

## 🏁 Getting Started

<div align="center">

### 📱 **For Android Users**

</div>

```bash
# 1️⃣ Download APK
Click "Download APK" button above or go to Releases/BallRolling-v1.0.apk

# 2️⃣ Install on Android
Enable "Unknown Sources" in Settings → Install APK

# 3️⃣ Play!
Launch the game and start rolling!
```

<div align="center">

### 🎮 **For Unity Developers**

</div>

```bash
# 1️⃣ Clone the Repository
git clone https://github.com/C0de-N1nja/Ball-Rolling-3D.git

# 2️⃣ Open in Unity
Unity Hub → Add → Select Project Folder

# 3️⃣ Required Unity Version
Unity 2022.3 LTS or newer

# 4️⃣ Play in Editor
File → Open Scene → Game Scene → Press Play
```

### 📋 **Requirements**
- 🎮 Unity 2022.3 LTS+
- 📝 TextMeshPro Package
- 🖼️ Unity UI Package
- 🎵 Audio clips (button, coin, obstacle sounds)

---

<div align="center">

**🎮 Ready to roll? Download now and challenge yourself to reach new distances!**

</div>