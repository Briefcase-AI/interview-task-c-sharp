# interview-task

Welcome to interview task at Briefcase 👋

Prerequisites to run this repo
1. node
2. npm package manager

To install this repo run

```bash
npm i
```

To run the task do

```bash
npm run task
```

### Task 1: extract essential information from invoice or receipt using openai API

This information includes

- document type (e.g. invoice or receipt)
- date
- due date
- supplier name
- currency
- total amount
- tax amount
- description
- document reference (e.g. invoice number)

### Task 2: return null for fields that are not possible to be extracted

For example if document has no reference, then document reference should be null

### Task 3: extract additional metadata

- location
- VAT number (typically in format GB-<numbers>)