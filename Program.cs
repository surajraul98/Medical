// See https://aka.ms/new-console-template for more information
using MedicalShop;

MedicalStore store = new MedicalStore();
    try {
        List<Medicine> medicines = store.GetMedicines();
            foreach (var medicine in medicines) {
                Console.WriteLine($"Medicine Id : {medicine.MedicineId}, Name : {medicine.MedicineName} ,price : {medicine.Price}, Quantity: {medicine.Quantity}");
            }
        double totalAmount= store.GetPurchaseAmount(medicines);
        Console.WriteLine($"Total Purchase Amount: {totalAmount}");

    }
    catch (NoMedicineFoundException e) { 
        Console.WriteLine(e.Message);
    }
