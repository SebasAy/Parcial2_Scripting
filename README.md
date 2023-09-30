# Parcial2_Scripting

### Integrantes
* Sebastian Ayala : 000424790
* Juan Sebastián Giraldo : 000425629
### Diseño orientado a objetos 
| Nombre | Tipo | Atributos | Metodos |
| --- | --- | --- | --- |
| Bike | ***clase*** | speed, grip, acceleration, handle  | CreateChassis, CanRide, Initialize parameter, UpdateParameters, AddFrontWheel, AddBackWheel, AddEngine, AddMuffler |
| Wheel | ***superclase*** | speed, grip, acceleration, handle | Wheel |
| FrontWheel | ***clase*** | speed, grip, acceleration, handle | FrontWheel (Base Wheel) |
| BackWheel | ***clase*** | speed, grip, acceleration, handle | BackWheel (Base Wheel) |
| Chassis | ***clase*** | none | Chassis |
| Engine | ***clase*** | speed, acceleration, handle | Engine |
| Muffler | ***clase*** | acceleration | Muffler |
