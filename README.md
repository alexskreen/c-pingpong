# _Ping Pong!_

####_Find doctors near you based on what issue you are having, or search for a doctor by name!_

#### By _**Alex Skreen**_

## Description
_Use branching, looping and other foundational C# concepts to build working console applications with C#. Don't worry about trying to complete all the exercises. Focus on getting more comfortable with C# and understanding key concepts._

## Setup/Installation Requirements

### Node install

#### For macOS:
_If Homebrew is not installed on your computer already, then install Homebrew by entering the following two commands in Terminal:_
* ``$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"``
* ``$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile``

_Install Git with the following command:_
* ``$ brew install git``

_Next, install Node.js by entering the following command in Terminal:_
* ``$ brew install node``

#### For Windows:
_Please visit the [Node.js website](https://nodejs.org/en/download/) for installation instructions._

### Setup/install this application

_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone https://github.com/alexskreen/DoctorLookup``
* ``$ cd doctorlookup``

_Confirm that you have navigated to the doctor lookup directory (e.g., by entering the command_ ``pwd`` _in Terminal). Next, add a file named .env to project root directory (e.g., by entering the command_ ``touch .env`` _in Terminal)._
* _Make an API key for the [BetterDoctor API site](https://developer.betterdoctor.com/) by navigating to the linked website and clicking "sign up of login to get an API Key"_
* _Store your API key for the BetterDoctor API in first line of the .env file in the following format: API_KEY = {replace curly braces and this text with your API key}_

_Next, install node package manager (npm) at the project's root directory via the following command:_
* ``$ npm install``

_Open this application via live server using the following command:_
* ``$ npm run start``

_To view/edit the source code of this application, open the contents of the camping directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._



## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
| User enters a number | 3 | Application takes in number "3" |
| Application will return all numbers from 1 to the user input | 3 | 1, 2... |
| Application will return "ping" if the returned number is divisible by 3 | 3 | 1, 2, ping |
| Application will return "pong" if the returned number is divisible by 5 | 5 | 1, 2, ping, 4, pong |
Application will return "ping-pong" if the returned number is divisible by both 3 and 5 | 15 | ...14, ping-pong, 16 |



## Support 

_The software is provided as is. If you experience an issue please reach out to me using the contact information provided._


## Built With

* [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML) - Simple Scaffolding
* [JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript) - Used for interactivity in the page
* [jQuery](https://jquery.com/) - Used to interact with the DOM
* [Bootstrap 4.4](https://getbootstrap.com/) - Used for styling
* [webpack](https://webpack.js.org/)
* [ESLint](https://eslint.org/)
* [Node.js](https://nodejs.org/en/)
* [Uglifyjs](https://www.uglifyjs.net/)
* [BetterDoctor API](https://developer.betterdoctor.com/)



### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Alex Skreen_**