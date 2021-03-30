# Abbyy Flexi Capture

* Abbyy offers solutions to find,extract and action information through intelligent capture, analysis and understanding of data
* Optical Character Recognition is the electronic or mechanical conversion of images of types, handwritten, or printed text into machine encoded text, whether from a scanned document , a scene-photo or from subtitle text superimposed on an image
* Characters are recognized as:
    1. based on their models
    2. by several classifiers for maximum accuracy
    3. After line detection, different classifiers such as Raster, Contour, Structure, Feature differentiating and so on are applied
* Intelligent Character Recognition (ICR) reads hand-printed text using ```FineReader``` which uses special dictionaries to verify names,surnames, dates and addresses etc

* FlexiCapture is used to intelligently classify, extract, and serve critical data from incoming images and document streams to decision makers for better performance, document workflow process trasparency and workload predictability
* Fundamental data extraction operations are:
    1. Classification
    2. Optical Recognition
    3. Verification
    4. Export to ERP,ECM or BPM systems

## FlexiCapture Architecture
* FlexiCapture is a set of several applications that comprise document processing servers and stations
* Server Components include:
    1. Application Server -> The web service in Internet Information Services (IIS) that provides user authorization and authentication functionality, and also enables the communication betweem client and server components
    2. License Server -> The service that stores information about current license terms and allowed uses of the system
    3. Processing Server -> The service that manages the processing stations that enable distributed processing
    4. Database -> Stores information about users, processing settings, documents that are being processed, and the statistics for the documents that were processed
    5. File Storage -> Stores images of the documents that are being processed and the data captured from these documents
* Client Components include:
    1. Administration and Monitoring Console -> Setting up Abbyy FlexiCapture and monitor its operation
    2. Project Setup Station -> Setting up document processing

<img src="Images\FlexiComponentsInteraction.png" />
