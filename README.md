# WCF Recipe App 🍽️

This is a **sample WCF project** that demonstrates how to build a SOAP-based web service in C# using WCF.

## 🚀 Features
- ✅ Self-hosted WCF service (`RecipeWcfHost`)
- ✅ WCF client (`RecipeClient`) to consume the service
- ✅ Uses `ServiceHost` to expose a SOAP API
- ✅ Fetches and displays recipe data

## 📌 How to Run
1. Clone this repository:
git clone https://github.com/yana-hris/WCF-recipe-app.git
cd WCF-recipe-app
2. Open the Project in Visual Studio
3. Rightclick the Solution in Solution Explorer and select **Configure Startup Projects**
4. Set all 3 projects to **Start** (Multiple Startup Projects):
- RecipeClient
- RecipeWcfHost
- RecipeWcfService
5. Press (`F5`) to start all projects simultaneously
7. In the console you will see the fetched data (recipes).

## 🛠 Technologies Used
- C# (.NET Framework)
- Windows Communication Foundation (WCF)
- Console App for self-hosting

## 📷 Screenshots
| WCF Service Running | Client Fetching Recipes |
|---------------------|------------------------|
| ![WCF Running](https://via.placeholder.com/500x300) | ![Client Output](https://via.placeholder.com/500x300) |

## 🤝 Contributing
Feel free to fork this repo and improve it! 🚀

---
