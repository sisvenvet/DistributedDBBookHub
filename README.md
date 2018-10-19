Used WCF services which support distributed transactions.
It is a good practice to implement WCF service in three or more layers. The three layers are the service interface layer, the business logic layer, and the data access layer.
Service interface layer includes the service contracts and operation contracts that are used to define the service interfaces.
Business logic layer applies the actual business logic to the service operations.
Data access layer takes care of all the tasks needed to access the underlying databases.
The business entities project holds all business entity object definitions such as products, customers, and orders. These entities are used across the business logic layer, the data access layer, and the service layer. They are not seen outside of the service. 
The business entities by themselves do not act as a layer. They are pure C# classes representing internal data within service implementations. There is no logic inside these entities.
