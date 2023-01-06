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
    "approvedBy": "",
    "stubs": {}
}

def sap2oracle(sap, oracle):
    # oracle['operatingUnit'] = 
    # oracle['PO'] = sap['poNumber']
    # oracle['rev'] = 
    oracle['supplier'] = sap['vendor']['name']
    oracle['shipTo'] = sap['shipTo']['name']
    # oracle['buyer'] = 
    oracle['created'] = sap['poDate']
    oracle['type'] = sap['documentType']
    oracle['site'] = sap['shipTo']['address']
    # oracle['billTo'] = 
    # oracle['status'] = 
    # oracle['pCard'] = 
    # oracle['contact'] = 
    # oracle['currency'] = 
    # oracle['total'] = 
    # oracle['description'] = 

    itemcount = len(sap['items'])
    oracle['items'] = oracle['items'] * itemcount
    for i in range(itemcount):
        # oracle['items'][i][] = sap['items'][i][]
        oracle['items'][i]['num'] = sap['items'][i]['itemNo']
        # oracle['items'][i]['type'] = sap['items'][i][]
        oracle['items'][i]['item'] = sap['items'][i]['vendorItemCode']
        # oracle['items'][i]['rev'] = sap['items'][i][]
        # oracle['items'][i]['job'] = sap['items'][i][]
        # oracle['items'][i]['category'] = sap['items'][i][]
        oracle['items'][i]['description'] = sap['items'][i]['itemCodeItemDescription']
        oracle['items'][i]['UOM'] = sap['items'][i]['UOM']
        oracle['items'][i]['quantity'] = sap['items'][i]['quantity']
        oracle['items'][i]['price'] = sap['items'][i]['unitPrice']
        # oracle['items'][i]['prommised'] = sap['items'][i][]
        oracle['items'][i]['needBy'] = sap['items'][i]['deliveryDate']
        # oracle['items'][i]['supplierItem'] = sap['items'][i][]
        # oracle['items'][i]['supplierConfigID'] = sap['items'][i][]
        oracle['items'][i]['amount'] = sap['items'][i]['amount']
        # oracle['chargeAccount'][i]['category'] = sap['items'][i][]

    oracle['stubs']['company'] = {}
    oracle['stubs']['company']['companyName'] = sap['company']['companyName']
    oracle['stubs']['company']['address'] = sap['company']['address'] 
    oracle['stubs']['company']['contactNo'] = sap['company']['contactNo']
    oracle['stubs']['company']['TIN'] = sap['company']['TIN']
    oracle['stubs']['vendor'] = {}
    oracle['stubs']['vendor']['address'] = sap['vendor']['address']
    oracle['stubs']['vendor']['contactNo'] = sap['vendor']['contactNo']
    oracle['stubs']['shipTo'] = {} 
    oracle['stubs']['shipTo']['contactNo'] = sap['shipTo']['contactNo']
    oracle['stubs']['pageNumber'] = sap['pageNumber']
    oracle['stubs']['tax'] = sap['tax']
    oracle['stubs']['totalPlusTax'] = sap['totalPlusTax']
    oracle['stubs']['termsAndCondition'] = {}
    oracle['stubs']['termsAndCondition']['payment'] = sap['termsAndCondition']['payment']

    return oracle

def sap2netsuite(sap, netsuite):
    netsuite['document'] = sap['documentType']
    netsuite['companyName'] = sap['company']['companyName']
    netsuite['address'] = sap['company']['address']
    netsuite['poNumber'] = sap['poNumber']
    netsuite['poDate'] = sap['poDate']

    # netsuite['purchaseFrom'] =
    # netsuite['purchaseFrom']['vendorID'] = 
    netsuite['purchaseFrom']['vendorName'] = sap['vendor']['name']
    netsuite['purchaseFrom']['address'] = sap['vendor']['address']
    # netsuite['purchaseFrom']['contactName'] =

    # netsuite['shipTo'] =
    netsuite['shipTo']['companyName'] = sap['shipTo']['name']
    netsuite['shipTo']['address'] = sap['shipTo']['address']
    # netsuite['shipTo']['contactName'] =

    # netsuite['shippingMethod'] =
    netsuite['paymentTerms'] = sap['termsAndCondition']['payment']
    netsuite['requiredByDate'] = sap['items'][0]['deliveryDate']

    # netsuite['items'] =
    itemcount = len(sap['items'])
    netsuite['items'] = netsuite['items'] * itemcount
    netsuite['stubs']['items'] = list()
    for i in range(itemcount):
        netsuite['items'][i]['itemDescription'] = sap['items'][i]['itemCodeItemDescription']
        netsuite['items'][i]['quantity'] = sap['items'][i]['quantity']
        netsuite['items'][i]['unitPrice'] = sap['items'][i]['unitPrice']
        netsuite['items'][i]['amount'] = sap['items'][i]['amount']
        itemstub = {}
        itemstub['itemNo'] = sap['items'][i]['itemNo']
        itemstub['vendorItemCode']= sap['items'][i]['vendorItemCode']
        itemstub['UOM']= sap['items'][i]['UOM']
        netsuite['stubs']['items'].append(itemstub)

    netsuite['subtotal'] = sap['total']
    netsuite['salesTax'] = sap['tax']
    netsuite['orderTotal'] = sap['totalPlusTax']
    netsuite['approvedBy'] = sap['termsAndCondition']['issuedBy']

    oracle['stubs']['company'] = {}
    oracle['stubs']['company']['contactNo'] = sap['company']['contactNo']
    oracle['stubs']['company']['TIN'] = sap['company']['TIN']
    oracle['stubs']['vendor'] = {}
    oracle['stubs']['vendor']['contactNo'] = sap['vendor']['contactNo']
    oracle['stubs']['vendor']['TIN'] = sap['vendor']['TIN']
    oracle['stubs']['shipTo'] = {} 
    oracle['stubs']['shipTo']['contactNo'] = sap['shipTo']['contactNo']
    oracle['stubs']['pageNumber'] = sap['pageNumber']
    oracle['stubs']['termsAndCondition'] = {}
    oracle['stubs']['termsAndCondition']['remarks'] = sap['termsAndCondition']['remarks']

    return netsuite

def oracle2netsuite(oracle, netsuite):
    netsuite['document'] = oracle['type']
    # netsuite['companyName'] = 
    # netsuite['address'] = 
    netsuite['poNumber'] = oracle['PO']
    netsuite['poDate'] = oracle['created']

    # netsuite['purchaseFrom'] =
    # netsuite['purchaseFrom']['vendorID'] = 
    netsuite['purchaseFrom']['vendorName'] = oracle['supplier']
    # netsuite['purchaseFrom']['address'] = 
    # netsuite['purchaseFrom']['contactName'] =

    # netsuite['shipTo'] =
    netsuite['shipTo']['companyName'] = oracle['shipTo']
    netsuite['shipTo']['address'] = oracle['site']
    # netsuite['shipTo']['contactName'] =

    # netsuite['shippingMethod'] =
    # netsuite['paymentTerms'] = 
    netsuite['requiredByDate'] = oracle['items'][0]['needBy']

    # netsuite['items'] =
    itemcount = len(sap['items'])
    netsuite['items'] = netsuite['items'] * itemcount
    netsuite['stubs']['items'] = list()
    for i in range(itemcount):
        netsuite['items'][i]['itemDescription'] = oracle['items'][i]['description']
        netsuite['items'][i]['quantity'] = oracle['items'][i]['quantity']
        netsuite['items'][i]['unitPrice'] = oracle['items'][i]['price']
        netsuite['items'][i]['amount'] = oracle['items'][i]['amount']
        itemstub = {}
        itemstub['UOM'] = oracle['items'][i]['UOM']
        itemstub['rev'] = oracle['items'][i]['rev']
        itemstub['job'] = oracle['items'][i]['job']
        itemstub['category'] = oracle['items'][i]['category']
        itemstub['promised'] = oracle['items'][i]['promised']
        itemstub['supplierItem'] = oracle['items'][i]['supplierItem']
        itemstub['supplierConfigID'] = oracle['items'][i]['supplierConfigID']
        netsuite['stubs']['items'].append(itemstub)

    netsuite['subtotal'] = oracle['total']
    # netsuite['salesTax'] = 
    # netsuite['orderTotal'] = 
    netsuite['approvedBy'] = oracle['buyer']

    netsuite['stubs']['description'] = oracle['description']

    netsuite['stubs']['operatingUnit'] = oracle['description']
    netsuite['stubs']['rev'] = oracle['description']
    netsuite['stubs']['billTo'] = oracle['description']
    netsuite['stubs']['status'] = oracle['description']
    netsuite['stubs']['pCard'] = oracle['description']
    netsuite['stubs']['contact'] = oracle['description']
    netsuite['stubs']['currency'] = oracle['description']
    netsuite['stubs']['type'] = oracle['description']

    return netsuite

import json
import sys

# Taking input from command line
# cmd line: python jsontranslator.py [PATH TO INPUT FILE] [MODE]
mode = sys.argv[-1] # 1: sap2oracle, 2: sap2netsuite, 3: oracle2netsuite
path = sys.argv[-2]
  
# Opening JSON file
f = open(path)  
src = json.load(f)
# print(json.dumps(sap, indent = 4, sort_keys=True))

# Closing file
f.close()

oracle = oracleform
netsuite = netsuiteform

if mode == 1:
    out = sap2oracle(src, oracle)
elif mode == 2:
    out = sap2netsuite(src, netsuite)
elif mode == 3:
    out = oracle2netsuite(src, netsuite)
else:
    out = src

with open("jsontrans_OUT.json", "w") as outfile:
    json.dump(out, outfile)