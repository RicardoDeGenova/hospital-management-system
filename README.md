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

Functionality (must-haves):
  - Must print patient forms with fields ready to also be handwritten after printed
  - Iternationalization (English, Haitian Kreyol and Spanish, currently)
  - One user starts the patient records and another one finishes it (separate it into several parts)

Config:
  - Use SQLite for local config
  - Try to find server automatically


### Current Triage Patient Form
![image](https://github.com/RicardoDeGenova/hospital-management-system/assets/79471515/52eaf41f-92bb-49b6-9057-ba60f463a469)


Inicial meds they use, should already load db with it:

  - Acetaminophen + caffeine
  - Acetaminophen drops
  - Acetaminophen susp
  - Acetominophen 500mg
  - Acyclovir 400mg
  - Acyclovir cream
  - Albendazole 400mg
  - Albendazole 400mg susp
  - Amitryptiline 25mg 
  - Amlodipine 10mg
  - Amoxcillin susp
  - Amoxicillin + Clauvanate susp
  - Amoxicillin 500mg
  - Antigripal
  - Aspirin 325mg
  - Aspirin 81mg
  - Atenolol 50mg
  - Azithromycin 500mg
  - Bactrim cap Bactrim susp 
  - B Complex
  - Calcium Carbonate 
  - Carvedilol 12.5mg
  - Cephelaxin 250 susp 
  - Cephelaxin 500mg 
  - Ceterizine 10mg
  - Ciprofloxacin 500mg
  - Citicolina
  - Clotrimazol creme 
  - Clotrimazol ovules 500mg
  - Dexamethasone 8mg 
  - Diclofenac 50mg
  - Diphenhydramine 10mg/ml 
  - Diphenhydramine 25mg 
  - Diphenhydramine drops 
  - Doxycycline 100mg 
  - Enalapril 10mg
  - Enalapril 20mg
  - Ensure liquid
  - Ensure powder
  - Fluconazole 150mg
  - Fluoride Varnish
  - Furosemide 40mg
  - Furosemide 40mg IV Gentamicina cream Gencloben cream
  - Griseofulvin 500mg
  - Griseofulvin suspension 
  - Hydrocortisone cream 
  - Iron Sulfate
  - IV Fluids Dextrose
  - IV Fluids Normal Saline
  - Ivermectin 6mg
  - Ibuprofen 400mg
  - Ibuprofen 600mg
  - Ibuprofen 800mg
  - Jabon de azufre Lasurtin
  - Levofloxacin 500mg
  - Lidocaine 2% 
  - Lisinopril 10mg 
  - Loratadine 10mg
  - Oral hydration salts
  - Otoful gotas 
  - Meloxicam 
  - Metformin 500mg 
  - Metformin 850mg
  - Metoclopramide 10mg
  - Metronidazole + Nistatina
  - Metronidazole 500mg
  - Montelukast 10mg
  - Multivitamins
  - Multivitamins drops
  - Omeprazole 20mg
  - Prednisone 20mg
  - Permetherin lotion
  - Permetherin cream
  - Permetherin shampoo
  - Prenatal vitamins 
  - Salbutamol 5mg/ml
  - Spirinolactone 25mg 
  - Tamsulosin
  - Vaseline
