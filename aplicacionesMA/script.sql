
USE concesionarioMA;
GO

CREATE TABLE Vehiculos (
    Id INT IDENTITY(1,1) PRIMARY KEY,       
    Placa NVARCHAR(50) NULL,               
    Modelo NVARCHAR(100) NULL,              
    Precio FLOAT NOT NULL,                  
    FechaVenta DATETIME2 NULL,              
    Notas NVARCHAR(MAX) NULL                
);
GO

INSERT INTO Vehiculos (Placa, Modelo, Precio, FechaVenta, Notas)
VALUES ('ABC-123', 'Mazda 3 Grand Touring', 85500.50, '2026-03-15 10:30:00', 'Vehículo en excelente estado, entrega inmediata.');


INSERT INTO Vehiculos (Placa, Modelo, Precio, FechaVenta, Notas)
VALUES ('XYZ-789', 'Chevrolet Onix Turbo', 62000.00, '2026-06-20 14:15:00', 'Cliente solicitó polarizado de cortesía.');


INSERT INTO Vehiculos (Placa, Modelo, Precio, FechaVenta, Notas)
VALUES ('MNO-456', 'Renault Duster 4x4', 94000.00, NULL, 'Unidad de exhibición en vitrina principal.');
GO