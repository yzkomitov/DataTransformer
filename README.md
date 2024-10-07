# Group Task - _Data Transformer_

You are given a console app, which reads a json file, transforms it and then writes the output to a file.

### How to setup the project:
1. Open the DataTransformer solution
2. Set DataTransformer.App as a startup project
3. After running the app, a file (_output.json_) should be generated in your ~\bin\Debug\net6.0 folder

The code loads the _sample-data.json_ file and deserializes it. Each node contains the following data:
- Price date
- Delivery start
- Price
- Commodity
- Time unit
- Time zone
- Additional data

Possible time units are:
- HH (Half hour)
- D (Day)
- M (Month)

### Your tasks:
- Look at the code. Make sure you understand what it does. Flag or fix any issues, which you find. Get ready to explain what you did to solve the task and/or improve the code.
- Make sure the app runs and generates the output file.
- Modify the code in such a way that it calculates the delivery end for each row. The delivery end should be calculated, considering the time unit of the current row. You may achieve this by modifying the code in DataTransformerService.cs or in any other way, you would prefer. Please see the example input and output below.
- Propose code/architecture improvements. Please try to think of the application not as a simple console app, but rather assume it will become a bigger, more complex system.
- Feel free to ask any questions.

### Bonus task:
- Given the same input file, add support for exporting the output to a .csv file

##### Example Input:
#

```json
[
  {
    "PriceDate": "2023-01-29",
    "DeliveryStart": "2024-10-01 00:00",
    "Commodity": "EL",
    "TimeUnit": "D",
    "Price": "41.7157885453843",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Ivanov", "CreateTime": "2024-10-01"}
  },
  {
    "PriceDate": "2024-06-20",
    "DeliveryStart": "2024-01-04 15:00",
    "Commodity": "EL",
    "TimeUnit": "HH",
    "Price": "0.771616451262481",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Petrov", "CreateTime": "2024-03-01"}
  },
  {
    "PriceDate": "2024-12-04",
    "DeliveryStart": "2024-01-04 15:30",
    "Commodity": "EL",
    "TimeUnit": "HH",
    "Price": "3.16436737704419",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Petrov", "CreateTime": "2024-03-01"}
  },
  {
    "PriceDate": "2024-08-26",
    "DeliveryStart": "2027-04-01 00:00",
    "Commodity": "EL",
    "TimeUnit": "M",
    "Price": "301.989362671469",
    "TimeZone": "EET",
    "AdditionalData": {"CreateName":"Ivan Georgiev", "CreateTime": "2024-07-01"}
  }
]
```

##### Target Output:
#

```json
[
  {
    "PriceDate": "2023-01-29",
    "DeliveryStart": "2024-10-01 00:00",
    "DeliveryEnd": "2024-10-02 00:00",
    "Commodity": "EL",
    "TimeUnit": "D",
    "Price": "41.7157885453843",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Ivanov", "CreateTime": "2024-10-01"}
  },
  {
    "PriceDate": "2024-06-20",
    "DeliveryStart": "2024-01-04 15:00",
    "DeliveryEnd": "2024-01-04 15:30",
    "Commodity": "EL",
    "TimeUnit": "HH",
    "Price": "0.771616451262481",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Petrov", "CreateTime": "2024-03-01"}
  },
  {
    "PriceDate": "2024-12-04",
    "DeliveryStart": "2024-01-04 15:30",
    "DeliveryEnd": "2024-01-04 16:00",
    "Commodity": "EL",
    "TimeUnit": "HH",
    "Price": "3.16436737704419",
    "TimeZone": "CET",
    "AdditionalData": {"CreateName":"Ivan Petrov", "CreateTime": "2024-03-01"}
  },
  {
    "PriceDate": "2024-08-26",
    "DeliveryStart": "2027-04-01 00:00",
    "DeliveryEnd": "2027-05-01 00:00",
    "Commodity": "EL",
    "TimeUnit": "M",
    "Price": "301.989362671469",
    "TimeZone": "EET",
    "AdditionalData": {"CreateName":"Ivan Georgiev", "CreateTime": "2024-07-01"}
  }
]
```

##### Target Output - Bonus Task:
#

```csv
PriceDate;DeliveryStart;DeliveryEnd;Price;Commodity;TimeUnit;TimeZone;AdditionalData|CreateName;AdditionalData|CreateTime
2023-01-29 00:00:00;2024-10-01 00:00:00;2024-10-02 00:00:00;41,7157885453843;EL;D;CET;Ivan Ivanov;2024-10-01 00:00:00
2024-06-20 00:00:00;2024-01-04 15:00:00;2024-01-04 15:30:00;0,771616451262481;EL;HH;CET;Ivan Petrov;2024-03-01 00:00:00
2024-12-04 00:00:00;2024-01-04 15:30:00;2024-01-04 16:00:00;3,16436737704419;EL;HH;CET;Ivan Petrov;2024-03-01 00:00:00
2024-08-26 00:00:00;2027-04-01 00:00:00;2027-05-01 00:00:00;301,989362671469;EL;M;EET;Ivan Georgiev;2024-07-01 00:00:00
```
