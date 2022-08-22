# Assignment

Framework -> .Net 6
DB -> Mongo DB, Please note that to connect to Mongo Db.Please change the connection with string with username and password.

Video CLIP API ->  
SearchCriteriaController ->API dedicated to get search criteria i:e  will fetch drop dowm values of VideoDefinition & videoStandard from collection in Mongo DB.The Unique index is created on both collections.
VideoClipController -> Fetching all the video Clip based on videoDefinition and Video Standard.
UnitTest Casees -> Controller -> Not able to write , but can see similar test in TestCodeController in differenr API for reference.
Integration test for DB -> Wrtitten for Both service with XUnit Framework

ShowReelAPI ->
To save ShowReel with list of VideoClips and other properties. Created Uniques index on Name. 
UnitTest -> Controller -> Not able to write , but can see similar test in TestCodeController in differenr API for reference.
Integration test for DB -> Wrtitten for Both service with XUnit Framework.

TimeCode API ->
To calculate totalduration based on add and remove of videoclip in show reel.
UnitTest & Service Test -> USed NUnit Framework AND MoQ .

Automapper & Dependency Injection Used.

Note -> Logging part needs to be done.
