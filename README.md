# Document Register System
## _Introduction_


This project is Document Register application for an engineering firm. It allows each department to create their own document numbering structure. 
Department employees can then issue and track documents. Different levels of employees are given different levels of permissions through 
the EF Core Identity framework to Create/Edit/View documents and associated tables.

Each department has a Department Document Numbering Structure (DDNS). This consists of between 3 to 6 category segments. A category segment can contain 
predefined values or user-defined values.

When issuing a new document for department, each document segment must be populated from either a list of predefined values or a user-defined value 
as per the DDNS. Additional fields also need to be completed.

A document number is created using the values in its document segments as per the DDNS.

Once a document is issued, its revision, location and status can be modified

## Features

-	Create a Segment categories and Segment data
-	Create a Department Document Number Structure
-	Create documents according to a Department Document Number Structure

## Technologies used

-	.Net Core 8
-	Database: Microsoft SQL
-	CQRS pattern
-	AutoMapper
-	Blazor WASM
-	EF Core
-	.Net API

Database Schema overview
![DocGenDb_ERD](https://github.com/user-attachments/assets/11b06b1a-b890-452e-bd70-f66dfb4dfd8f)

## Application Overview
Register Page
![register](https://github.com/user-attachments/assets/ade22a1f-814c-4867-80d9-106772f766d1)

Login Page
![login](https://github.com/user-attachments/assets/7b361853-d340-4358-b182-d855a1444e71)

Homepage 
![landing page](https://github.com/user-attachments/assets/e553aff0-e735-4ea8-ad53-89191d1cb3f2)

Segment Categories
Index
![segment categories index](https://github.com/user-attachments/assets/d10637f6-9f12-4e09-ab5d-45779c18dce9)

Edit
![segment categories edit](https://github.com/user-attachments/assets/7877989f-4214-4cee-b265-97a05843b64e)

Department Document Number Structure
Create
![ddns create](https://github.com/user-attachments/assets/7a39fa06-5014-41a0-b831-381e3169e572)

Document
Create
![document create](https://github.com/user-attachments/assets/67aec5ef-3a57-4405-a766-1012ea5bba04)
