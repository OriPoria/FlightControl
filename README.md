# FlightControl
Flight control system where you can see the current flights on air and see their details
By clicking on the airplane on the map or on the table you can see the full flight detaisl and the full path of the flight on the map.
Technologies: Rest API for the server, JavaScript and ajax for the client's requests and css and Bootstrap for design.
You can add flight by using software like postman to make post request (api/flightplan), or add a json file by clicking the green button.


The json file format that you can add to the system and edit the its details as you wish:

{
 "passengers": 216,
 "company_name": "Arkia",
 "initial_location": {
 "longitude": 32,
 "latitude": 34,
 "date_time": "2020-10-02T17:12:21Z"
 },
 "segments": [
 {
 "longitude": -3,
 "latitude": 39,
 "timespan_seconds": 2650
 }
 ]
}
