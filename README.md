# Software-1-Inventory-Management-System
Inventory Management System - WGU C968 Performance Assessment <br>
📌 Overview <br>
This Windows Forms application is designed for managing inventory for a small manufacturing company. It replaces a spreadsheet-based system with a robust, object-oriented C# application. The system allows users to add, modify, delete, and search for parts and products, as well as associate parts with specific products.

🛠 Features <br>
✅ Main Form with search, add, modify, delete, and exit functionality for Parts and Products <br>
✅ Add/Modify Part Forms with In-House and Outsourced toggling <br>
✅ Add/Modify Product Forms with part association and disassociation logic <br>
✅ Input validation for numeric fields, min/max constraints, and inventory boundaries <br>
✅ Prevents deletion of parts associated with products without user confirmation <br>
✅ All data bound using BindingList<T> to automatically update the UI <br>
🧱 Technologies Used <br>
C# <br>
Windows Forms (.NET Framework 4.7.2) <br>
Visual Studio 2022 <br>
Object-Oriented Design Principles <br>
🧩 Class Architecture <br>
Part (abstract): Base class with common properties <br>
InHouse / Outsourced: Derived classes with specific fields <br>
Product: Includes associated parts <br>
Inventory: Static class managing all products and parts <br>
