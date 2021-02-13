# MongoDB

# Notes
* There are components:
    1. Server
    2. Client
* Each document has a unique column known as ```_id``` created automatically by mongodb
* Commands in ```MongoDB``` are case sensitive
* With a single command you can insert a document in the collection and the MongoDB creates that collection on the fly
* To Exit from mongoShell use ```exit```

# Useful Commands
* To Create a database, run ```use``` as ```use database-name```
* To Check the database available in system ```show dbs```
* To drop database, first ```use databasename``` and followed by ```db.dropDatabase()```
* To Create a collection, run ```db.createCollection(collectionname,constraints)``` as ```db.createCollection("teachers",{capped:true,size:9232768})```
* To show ```collections``` available in a database, run ```show collections```
* To drop a collection, run ```db.collection_name.drop()```
* To list the inserted documents, run ```db.collection_name.find()```
* To Insert one document, run ```db.collection_name.insertOne({all key value pairs})```
* An Example to insert many documents is 
```sql
db.orders.insert([{ _id: 1, cust_id: "abc1", ord_date: ISODate("2012-11-02T17:04:11.102Z"), status: "A", amount: 50 },
{ _id: 2, cust_id: "xyz1", ord_date: ISODate("2013-10-01T17:04:11.102Z"), status: "A", amount: 100 },
{ _id: 3, cust_id: "xyz1", ord_date: ISODate("2013-10-12T17:04:11.102Z"), status: "D", amount: 25 },
{ _id: 4, cust_id: "xyz1", ord_date: ISODate("2013-10-11T17:04:11.102Z"), status: "D", amount: 125 },
{ _id: 5, cust_id: "abc1", ord_date: ISODate("2013-11-12T17:04:11.102Z"), status: "A", amount: 25 }])
```
* To Find documents based on some conditions, run ```db.collection_name.find(dictionary-of-parameters)```
* The ```In``` Operator from ```RDBMS``` is used in ```MongoDB``` as ```db.collection_name.find(status: {$in: ["A","D"]})```
* To Update the documents we have
    1. ```db.collection.updateOne(<filter>,<update>,<options>)``` -> update the document that is found first
    2. ```db.collection.updateMany(<filter>,<update>,<options>)``` -> Update all the documents matching the given condition
    3. ```db.collection.update(<filter>,<update>,<options>)```
* An Example of Update is 
```sql
db.inventory.updateOne(
... {item:"paper"},
... {
... $set: {"size.uom":"cm",status:"P"},
... $currentDate: {lastModified:true}
... }
... )
```
* To replace the document, run ```db.collection_name.replaceOne(<filter>,{new key value pair})```, this will replace one document which matches the given filter condition while the ```Object Id``` remains the same
* To delete all documents from a collection, ```db.collection_name.deleteMany()```
* To delete documents with specific criteries, ```db.collection_name.deleteMany(<filter>)``` as ```db.collection_name.deleteMany({status:"A"})```
* To delete record with the first occurence of matching filter, use ```db.collection_name.deleteOne()```

## Options in Collections
1. capped:type:boolean
    * Takes only true and false
    * Once the collection reaches that limit, it starts overwriting old entries
    * On specifying ```Capped``` to true, we need to define the size parameter
2. size:type:number
    * This specifies the max size of collection
3. max:type:number
    * This specifies the max number of documents a collection can hold
    * If max is 100, then after 100 documents, new entries will be overwrited from 1 position
4. autoIndexId:type:boolean
    * The default value is false
    * It automatically creates index on the field _id for each document

## Operators
1. $eq
2. $gt
3. $gte
4. $in
5. $it
6. $ite
7. $ne -> all values not equal to specific value
8. $nin -> match none of the values specified in array
9. $and ->```db.collection_name.find({$and: [{col1:val1},{col2:{$lt:$val2}}]})``` and ```,``` also represents ```and```
10. $not
11. $nor
12. $or -> ```db.collection_name.find({$or: [{col1:val1},{col2:{$lt:$val2}}]})```
13. $exist -> Matches documents that have the specifeid field, ```db.records.find({field_name:{$exists:true}})```
14. $type -> Selects documents if a field is of the specified type
``` sql
db.inventory.find({status:"A",qty:{$lt:30}})
```

## Projection
* Used to represent only the columns that you want to display
* This is basically another parameter to be passed to ```find``` method
* ```db.collection_name.find({parameters of conditions},{columns to display})```
* ```Display``` is referred as ```1``` and ```0``` not to display
* Example: ```db.inventory.find({status:"D"},{item:1,status:1})```


## Aggregare Functions
* This is an example of aggregate functions
```sql
db.collection_name.aggregate(
    [
        {$match: {status:"A}},
        {$group: {_id:"cust_id",total: {$sum: "$amount"}}}
    ]
)
```
* It is modeled on the concept of data processing pipelines

## Indexes
* Indexes are special data structures that store a small portion of the collections data set in an easy to traverse form
* The index stores the value of a specified field or set of fields, ordered by the value of the field
* The ordering of the index entries supports efficient equality matches and range-based query operations
* MongoDB by defaut uses ```_id``` for Index
* We can not drop ```_id``` from a document
* To create index, ```db.collection.createIndex(<key and index type specification>,<options>)```
* Create a single key descending index on the name field: ```db.collection.createIndex({name:-1})```
* The Default name of an index is the ```concatenation``` of ```key_value``` pair
* Index is used by ```Database-engine``` for executing the ```Search``` queries
