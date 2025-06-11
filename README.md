# LoanApplicationSite
This project demonstrates a Web Application UI automated test using Playwright, Specflow, .NET 8.0, NUnit framework. It includes using (Behavior Driven Development) and POM (Page Object Model) concepts. The project is designed to automate the process of applying for a loan on a fictional loan application website.

My creating a readable and maintainable code approach has helped me to pick these technologies mentioned above for this project. 

## Table of Contents
- [Introduction](#introduction)
- [Installation](#installation)
- [Usage](#usage)

# Introduction
The goal of the project is basically automated the of applying for a loan on a fictional loan application website. The project used the latest as well as existing technologies to demonstrate an efficient and effective way to write a clean test code that can be reused and maintained. This project applied the behavior-driven development (BDD) approach to write test scenarios in a natural language using Gherkin syntax. The project also used the Page Object Model (POM) design pattern to encapsulate all the details of HTML elements into a page object, which can be reused across different test files. And the project also used the Playwright framework to interact with the web application and perform actions such as clicking buttons, filling forms, and verifying results.
## Installation

### Prerequisites

    - Node.js (v20 or higher)
    - Mocha installed 
    - Playwright installed
    - Web browser installed
    - Cucumber installed
    - Other necessary tools or dependencies

### Steps to install
    
1. Clone the repository
    ```bash
    git clone https://github.com/kendkhong/FlightSearchAutomation.git
    ```
2. Navigate into the project folder:
    ```bash
    cd FlightSearchAutomation
    ```
3. Install dependencies
    ```bash
    npm install
    npm install @playwright/test --save-dev
    npx playwright install
    npm install @cucumber/cucumber
    ```

## Usage

### Running the Project

#### Mocha Project with Page Object Model
1. To run tests:
    ```bash
    npx playwright test tests/FlightSearch.spec.js --headed
    ```


#### Cucumber project with Page Object Model

1. To run tests:
    ```bash
    npx cucumber-js --exit
    ```

