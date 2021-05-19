# Microsoft Workshop

* <a href="portal.azure.com">Open Azure Console</a>

# Custom Vision
## Create
* Name : Apple Recognizer
* Subscription: Azure for students starter
* Location: (Europe) West Europe
* click on link and select the try for free option(Prediction pricing tier)
* Prediction price choose ```F0 2 transactions per second```
* start a new project
* Resource Group(AppleRECOG)
* Training pricing choose ```F0```

* From the bell icon, Goto Resource and run specific service
* Goto ```Custom Vison Portal``` from 2 point  for basic theory

## Working on another portal , seperately for Custom Vision
* Further to work open ```customvision.ai```
* Create a new project
* Give a name: AppleVSOrange
* Description: Tells whether image is an apple or orange
* resource: ApppleRecog[F0]
* Project Types: Classification
* Classification Types: MultiClass (used for single level classification)
* Multilabel: not used here but generally for multi level classification
* Domains: Food
* Note : 5 images are required minimum per tag

## Create a TAG
* Just click on ```+``` icon on Tags
* give a name
* upload images of ```orange``` and add tag ```given-name```
* upload images

## Train
* click on ```green``` colored ```train``` icon on top of page
* you find 2 ways ( Choose Training Type)
    1. Fast Training
    2. Advanced Training
* Choose Advanced Training and time ```3 hours```

## model info
* Precision ~> tells you the rate of correct identification
* Recall ~> correct identified / total identified
* Go to Prediction tab
* Start qucik test
* upload image and check its probability


# Azure Fundamentals
