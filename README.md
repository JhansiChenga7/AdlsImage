# ADLS Image Upload Demo

ASP.NET Core Web API demonstrating image upload and retrieval using  
Azure Data Lake Storage Gen2 (ADLS Gen2) via Azure Blob Storage.

---

## Overview
This project shows how to:
- Connect a .NET Web API to Azure Data Lake Storage Gen2
- Upload images to Azure Blob Storage
- Retrieve images through API endpoints
- Run the application using GitHub Codespaces

ADLS Gen2 is built on top of Azure Blob Storage with hierarchical namespace enabled.

---

## Architecture
Client (Swagger / Browser)
        |
ASP.NET Core Web API
        |
Azure Blob SDK
        |
Azure Storage Account (ADLS Gen2)

---

## Tech Stack
- .NET 8
- ASP.NET Core Web API
- Azure Storage Account (ADLS Gen2)
- Azure Blob Storage SDK
- Swagger (Swashbuckle)
- GitHub Codespaces

---

## Azure Setup
1. Create an Azure Storage Account
2. Enable **Hierarchical Namespace** (ADLS Gen2)
3. Create a Blob container named:
