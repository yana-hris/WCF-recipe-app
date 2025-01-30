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
| [image](https://github.com/user-attachments/assets/e27f42ae-0f37-4dfb-a389-d21f7c448dad)
()[image](https://github.com/user-attachments/assets/caecdc0a-ff0a-4333-a976-a5b557efcacb)
 |

## 🤝 Contributing
Feel free to fork this repo and improve it! 🚀

---
