namespace RentACarSimulation.Models;

public record Car(
    int Id,
    int ColorId,
    int FuelId,
    int TransmissionId,
    string CarState,
    int Kilometer,
    short ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    double DailyPrice
);