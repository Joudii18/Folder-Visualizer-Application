# 📁 SWE 316 – Homework #2  
### Composite & Strategy Design Patterns — Folder Visualizer  
**Language:** C# (.NET — WinForms / WPF)

---

## 👤 Course Information
- **Section:** F-03
- **Instructor:** Khalid Aljasser

---

## 📝 Problem Overview
This project demonstrates the **Composite Design Pattern** using a real-world example:

> A folder contains files and other folders — both should be treated uniformly.

The program allows the user to select a folder, then:

- Recursively reads all files & sub-folders  
- Builds an internal object structure  
- Computes folder sizes using a **single call**  

- Supports **two visualization strategies**  
✔ Tree view layout  
✔ Bar-chart style layout  

The visualization must be **drawn manually on a panel (no TreeView or ready-made controls)**.

---

## 🎯 Key Requirements (Summary)

- Composite pattern for File + Folder
- Strategy pattern for visualization styles
- Recursive traversal
- Show size beside each file/folder name
- Scrollbars if content exceeds panel
- Resizable UI
- Works with real directories

## 🧠 System Design — OOP + Design Patterns

### 🧩 Composite Pattern Structure

| Component | Responsibility |
|---------|----------------|
| `FileComponent` | Base abstract class |
| `FileLeaf` | Represents a file |
| `FolderComposite` | Represents a folder containing children |

Shared behavior is defined in the component.  
Folders override behavior to work recursively.

---

### 🌀 Strategy Pattern — Visualization Modes

| Strategy | Description |
|---------|-------------|
| `TreeVisualizer` | Draws hierarchical tree layout |
| `BarChartVisualizer` | Draws folder/file sizes as bars |

The **context** selects visualization dynamically.

## 📊 Displayed Information

<img src="output_sample.jpeg" alt="Sample Output" width="450">

# 👩‍💻 Technologies Used
- **C#**
- **.NET Framework**
- **Visual Studio**
- **WinForms / WPF**

---

## 📎 Academic Declaration
This project was developed as part of **SWE 316 — Software Design & Construction coursework.**

---
