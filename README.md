# LoanApplicationSite
This project demonstrates a Web Application UI automated test using Playwright, Specflow, .NET 8.0, and NUnit framework. It includes using (Behavior Driven Development) and POM (Page Object Model) concepts. The project is designed to automate the process of applying for a loan on a fictional loan application website. My approach of creating a readable and maintainable code has helped me to pick these technologies mentioned above for this project.

## Table of Contents
- [Introduction](#introduction)
- [Installation](#installation)
- [Usage](#usage)

# Introduction
The goal of the project is to automate testing the process of applying for a loan on a fictional loan application website. The project used the latest as well as existing technologies to demonstrate an efficient and effective way to write clean test code that can be reused and maintained. This project applied the behavior-driven development (BDD) approach to write test scenarios in natural language using Gherkin syntax. The project also used the Page Object Model (POM) design pattern to encapsulate all the details of HTML elements into a page object, which can be reused across different test files. And the project also used the Playwright framework to interact with the web application and perform actions such as clicking buttons, filling forms, and verifying results.
## Installation

### Prerequisites

    - Microsoft Visual Studio 2022 or later
    - .NET 8.0 SDK installed 
    - Playwright installed
    - Web browser installed
    - Specflow installed
    - NUnit installed
    - Other necessary tools or dependencies

### Steps to install
    
1. Clone the repository
    ```bash
    git clone https://github.com/kendkhong/LoanApplicationSite2
    ```

2. Open the project in Visual Studio

3. Open the NuGet Package Manager Console in Visual Studio to restore the dependencies

      1. Click on Tools from Menu > NuGet Package Manager > Package Manager Console
      2. Type the following command to restore dependencies:
           ```bash
           Update-Package -reinstall
           ```
## Usage

### Running the Project

1. Run the "LoanApplicationSiteCore" project in Visual Studio without Debugging by pressing `Ctrl + F5` or clicking on the "Start Without Debugging" button. This will launch the web application in your default web browser.
2. To run tests:

    Go to the "Test Explorer" pannel in Visual Studio and run all tests or select specific tests to run.


