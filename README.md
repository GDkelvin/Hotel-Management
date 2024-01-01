A. How to import database to sql server.<br>
1.Open Sql Server Management System and connect to your SQL Server instance.<br>
2. Right-click on "Databases" in Object Explorer.<br>
3. Select "Import Data-tier Application."<br>
![step 1](https://github.com/GDkelvin/Hotel-Management/assets/136468103/d76a908a-0a97-4f2c-b7fe-a10f8188c16f)<br>

4. Follow the wizard:<br>
5. Click "Next."<br>
6. Choose the .bacpac file.<br>
![Browse](https://github.com/GDkelvin/Hotel-Management/assets/136468103/5c49d939-efff-4c02-aabd-0bb156999056)
Click "Next."<br>
7. Review: Verify settings and click "Finish."<br><br>

B. Change connection in source code.
1. Open Server Explorer and go to properties<br>
![server explorer](https://github.com/GDkelvin/Hotel-Management/assets/136468103/2f297b22-6d8f-4f5c-bae7-8a507a3767ed)<br>

2. Copy the connection string.<br>
![connection string](https://github.com/GDkelvin/Hotel-Management/assets/136468103/01a4b1bf-da0d-455b-a676-23b6df16bcb5)<br>

3. paste the connection string to con.ConnectionString in function.cs file<br>
![connection string change](https://github.com/GDkelvin/Hotel-Management/assets/136468103/5e4433dd-5a1c-417f-948f-abe89c16ed0b)<br>
Change Data Source=ADMIN\SQLEXPRESS, for example to ADMIN\\\SQLEXPRESS (complete other if there are only one \ too) <br>
login account is: <br>
admin <br>
1234

