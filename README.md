# ClientServer

### Project Configuration

Inside **Configurations** directory is **appsettings.json**  

1. **DefaultDb** is connection string to database. For creating database from migrations string must be updated to current working mysql database.

2. **Address** is ip address for connection in local environment **localhost** works fine
3. **Port** is port for server listenin and client connection
4. **File** is file name where client logs will be saved


 
```
{
  "Config": {
    "DefaultDB": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
    "Address": "localhost",
    "Port": 9000,
    "File": "ClientLog.txt"


  }
}
```

---

### Database configuration 

All migrations files are created just trigger migrations inside **Package Manager Console** using: 

(**Make sure default selected project is Models**)

    Update-Database
  
  
  
---

### Start both files 

**Make sure two Server and Client projects are set as startup projects**


