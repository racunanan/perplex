sapform = {
    "documentType": "Purchase Order",
    "company": {
        
        "companyName": "",
        "address": "",
        "contactNo": "",
        "TIN": ""
        
    },
    "vendor": {
        "name": "",
        "address": "",
        "contactNo": "",
        "TIN": ""
    },
    "shipTo": {
        "name": "",
        "address": "",
        "contactNo": ""
    },
    "poNumber": "",
    "poDate": "dd/mm/yyyy",
    "pageNumber": "current/total",
    "items": [
        {
            "itemNo": 1,
            "vendorItemCode": "",
            "itemCodeItemDescription": "",
            "UOM": "",
            "deliveryDate": "dd/mm/yyyy",
            "quantity": 1,
            "unitPrice": 1,
            "amount": 1
        }
    ],
    "total": 1,
    "tax": 0.5,
    "totalPlusTax": 1.5,
    "termsAndCondition": {
        "payment": "",
        "issuedBy": "",
        "remarks": ""
    },
    "stubs": {}
}

oracleform = {
    "operatingUnit": "",
    "PO": "",
    "rev": 0,
    "supplier": "",
    "shipTo": "",
    "buyer": "",
    "created": "dd/month/yyyy hh:mm:ss",
    "type": "Standard Purchase Order",
    "site": "",
    "billTo": "",
    "status": "",
    "pCard": "",
    "contact": "",
    "currency": "",
    "total": 1,
    "description": "",
    "items": [
        {
            "num": 1,
            "type": "",
            "item": "",
            "rev": "",
            "job": "",
            "category": "",
            "description": "",
            "UOM": "",
            "quantity": 1,
            "price": 1,
            "promised": "",
            "needBy": "dd/month/yyyy hh:mm:ss",
            "supplierItem": "",
            "supplierConfigID": "",
            "amount": 1,
            "chargeAccount": ""
        },
        {}
    ],
    "stubs": {}
}

netsuiteform = {
    "document": "Purchase Order",
    "companyName": "",
    "address": "",
    "poNumber": "",
    "poDate": "dd/mm/yyyy",
    "purchaseFrom": {
        "vendorID": "",
        "vendorName": "",
        "address": "",
        "contactName": ""
    },
    "shipTo": {
        "companyName": "",
        "address": "",
        "contactName": ""
    },
    "shippingMethod": "",
    "paymentTerms": "30 days",
    "requiredByDate": "dd/mm/yyyy",
    "items" : [
        {
            "itemDescription": "",
            "quantity": "",
            "unitPrice": "",
            "amount": ""
        }
    ],
    "subtotal": 1,
    "salesTax": 0.5,
    "orderTotal": 1.5,
    "approvedBy": ""
}

import json
  
# Opening JSON file
f = open('jsontrans_SAP.json')
  
sap = json.load(f)
# print(json.dumps(sap, indent = 4, sort_keys=True))
  
# Closing file
f.close()

oracle = oracleform

# print(sap.keys())
# print(oracle.keys())

oracle['type'] = sap['documentType']
# oracle['PO'] = sap['company']
oracle['supplier'] = sap['vendor']['name']

oracle['shipTo'] = sap['shipTo']['name']
oracle['site'] = sap['shipTo']['address']

oracle['PO'] = sap['poNumber']
oracle['created'] = sap['poDate']
# oracle['PO'] = sap['pageNumber']

# need to loop pa for multiple items
oracle['num'] = sap['items'][0]['itemNo']
oracle['item'] = sap['items'][0]['vendorItemCode']
oracle['description'] = sap['items'][0]['itemCodeItemDescription']
oracle['UOM'] = sap['items'][0]['UOM']
oracle['needBy'] = sap['items'][0]['deliveryDate']
oracle['quantity'] = sap['items'][0]['quantity']
oracle['price'] = sap['items'][0]['unitPrice']
oracle['amount'] = sap['items'][0]['amount']

oracle['total'] = sap['total']
oracle['buyer'] = sap['termsAndCondition']['issuedBy']
oracle['description'] = sap['termsAndCondition']['remarks']

print(json.dumps(oracle, indent = 4, sort_keys=True))

with open("jsontrans_OUT.json", "w") as outfile:
    json.dump(oracle, outfile)