# LableProject — Barcode Label Printing Tool

A Windows desktop tool for designing label templates, importing serial lists from Excel and printing barcode labels.

> **Status:** archived, kept for reference and not maintained.

## What it does

1. **Define label templates:** set the label size and its fields. For each field, choose the Excel column it reads from, whether it is printed, whether it is rendered as a barcode, and whether it must be scanned.
2. **Import serial lists** from Excel files and link them to a label template.
3. **Print labels:** each Excel row is printed as one label. Barcode fields are rendered as **Code 128** (with checksum).
4. **Track scans:** scanned serials are recorded per imported list.

## Tech stack

- C#, **Windows Forms**, .NET Framework 4.8
- **Microsoft Access** database (OLE DB, typed DataSets)
- Microsoft Office Interop Excel for reading Excel files
- Zen.Barcode for Code 128 barcode generation
- `System.Drawing.Printing` for label layout and printing

## Project structure

```
LableProject/
├── AddLableForm.cs       Create and edit label templates and their fields
├── ListLableForm.cs      List of label templates
├── ExcelUploadForm.cs    Import an Excel serial list for a template
├── ExcelList.cs          Imported Excel lists
├── PrintBarcodeForm.cs   Preview, scan tracking and label printing
├── Class/                Excel reader and view models
└── LableDb.accdb         Local Access database (templates, fields, serial lists)
```

## Requirements

- Windows with .NET Framework 4.8
- Microsoft Access Database Engine (ACE OLE DB 12.0) and Microsoft Excel
