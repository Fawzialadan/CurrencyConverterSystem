# 🌍 Somali Currency Converter System

Kani waa nidaam dhammaystiran oo loo adeegsado sarrifka lacagaha caalamiga ah, kaas oo lagu dhisay tignoolajiyada **ASP.NET Core MVC**. Nidaamku wuxuu si toos ah (Real-time) u soo xogta sarrifka isagoo adeegsanaya API caalami ah, wuxuuna xogta ku kaydiyaa database-ka **Oracle**.

## 🚀 Tilmaamaha Mashruuca (Features)
*   **Real-time Exchange Rates:** Wuxuu isticmaalaa API si uu u helo qiimaha suuqa ee ugu dambeeyay (USD, EUR, SOS, iwm).
*   **Database Integration:** Dhammaan sarrifyada la sameeyo waxaa lagu keydiyaa **Oracle Database**.
*   **Conversion History:** Bog gaar ah oo lagu arki karo taariikhda sarrifyadii horay u dhacay.
*   **Responsive UI:** Waxaa loo naqshadeeyay si fudud oo qurux badan iyadoo la adeegsanayo **Bootstrap 5**.

## 🛠️ Tignoolajiyada la isticmaalay (Tech Stack)
*   **Backend:** ASP.NET Core MVC 10.0 (C#)
*   **Database:** Oracle Database Express Edition (XE)
*   **ORM:** Entity Framework Core
*   **API:** [Open Exchange Rates API](https://open.er-api.com/)
*   **Frontend:** HTML5, CSS3, JavaScript, Bootstrap

## ⚙️ Sida loo rakibo (Setup Instructions)

Si aad barnaamijkan ugu kiciyo kombiyuutarkaaga, raac tallaabooyinkan:

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/Fawzialadan/CurrencyConverterSystem.git](https://github.com/Fawzialadan/CurrencyConverterSystem.git)
    ```

2.  **Database Configuration:**
    Fur faylka `appsettings.json` oo ku habee **Connection String**-kaaga Oracle:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "User Id=YOUR_USER;Password=YOUR_PASSWORD;Data Source=localhost:1521/xe;"
    }
    ```

3.  **Apply Migrations:**
    Fur *Package Manager Console* gudaha Visual Studio, ka dibna qor:
    ```bash
    Update-Database
    ```

4.  **Run the Project:**
    Riix **F5** ama badhanka cagaaran ee **Run** si aad u socodsiiso barnaamijka.

---

## 👤 Developer
*   **Magaca:** Fawzialadan
*   **GitHub:** [@Fawzialadan](https://github.com/Fawzialadan)
*   **Status:** Working & Completed ✅

---
© 2026 - Currency Converter System
