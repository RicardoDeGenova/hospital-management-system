# Hospital Management - APL

Medical management system for [Ann Prepare Lavni (APL)](https://annpreparelavni.org) 

This will be a software developed especifically for APL's mission trip and hospitals, and it's current needs. It will not be a general hospital management system.

Framework Candidates:WPF, MAUI, Blazor

If MAUI gets some bug fixes with .NET 8, we'll probably go for that, otherwise with Blazor of WPF (current preference is Blazor to also have phone usage).

Constraints:
  - The software cannot rely on internet, they can sometimes stay days with no internet or with extremely low speeds;
  - It must be very sturdy and reliable, with a lot of redundancy, there is no option of remote updates (except on rare cases) as of now;
  - One of the computers locally must act as the server (they probably won't have a dedicated server for a while).
  - Since the users won't be very technical, it must be easy to install and maintain.


  We can make a totally offline service for the server, or we can make it offline-first but keep trying to save in the cloud until it manages it.
  For extra redundancy in the database, one option is to have it inspired in the blockchain, so every user has a copy of the db. Maybe use SQLite for local db (for simplicity). Or have an actual backup file saved periodically in another machine or external hard drive.

Functionality:
  - Must print patient forms with fields ready to also be handwritten after printed


Config:
  - Use SQLite for local config
  - Try to find server automatically
