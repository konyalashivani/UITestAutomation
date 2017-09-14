open canopy
open System
open runner
start chrome
let rand=new System.Random()
let RandomNumber = rand.Next(1, 1000)
once (fun _ ->
(url "http://www.turtletest.com/register")
)
test (fun _ ->
(
click "input[value='Submit']"
let NameFieldValidation=text "Name is required"
NameFieldValidation=="Name is required"
let EmailFieldValidation=text "Email not valid"
EmailFieldValidation=="Email not valid"
let PasswordFieldValidation=text "Password must be between 6 and 100 characters"
PasswordFieldValidation=="Password must be between 6 and 100 characters"
))
test (fun _ ->
(
"input[placeholder='Name']"<<String.Concat("shivani@2",RandomNumber)
"input[placeholder='Email']"<<String.Concat("konyalashivani2",RandomNumber,"@gmail.com")
"input[placeholder='Password']"<<"accenture@2017"
"input[placeholder='Repeat Password']"<<"accenture@2017"
click "input[value='Submit']" 
))
test (fun _ ->
(
let username=String.Concat("Hi ","shivani@2",RandomNumber,"!")
let logout= text username
click logout
elementTimeout <- 10.0
click "input[value='Login']"
let EmailFieldValidation=text "Invalid email or password"
EmailFieldValidation=="Invalid email or password"
"input[placeholder='Email']"<<String.Concat("konyalashivani2",RandomNumber,"@gmail.com")
click "input[value='Login']"
let PasswordFieldValidation=text "Invalid email or password"
PasswordFieldValidation=="Invalid email or password"
"input[placeholder='Password']"<<"acc"
click "input[value='Login']"
PasswordFieldValidation=="Invalid email or password"
"input[placeholder='Password']"<<"accenture@2017"
click "input[value='Login']"
))
test (fun _ ->
(
let applications=text "Applications"
click applications
click "input[value='Save']"
let NameFieldValidation=text "Name is required"
NameFieldValidation=="Name is required"
let PrivateFieldValidation=text "Private must be Yes or No"
PrivateFieldValidation=="Private must be Yes or No"
))
test (fun _ ->
(
"input[placeholder='Name']"<<"shivani"
"input[placeholder='Address']"<<"mdc5c mindspace"
"input[placeholder='Documentation']"<<"financial services documentation"
"input[placeholder='Owners']"<<"abc"
"input[placeholder='Developers']"<<"dotnet developers"
"*[placeholder='Notes']"<<"this application is based on the financial services"
"select[name='Private']"<<read "option[value='True']"
click "input[value='Save']"
))
test (fun _ ->
(
let suites=text "Suites"
click suites
click "input[value='Save']"
let ApplicationFieldValidation=text "Application is required"
ApplicationFieldValidation=="Application is required"
let NameFieldValidation=text "Name is required"
NameFieldValidation=="Name is required"
))
test (fun _ ->
(
"select[name='Application']"<<"shivani"
"input[placeholder='Name']"<<"NewSuite"
"input[placeholder='Version']"<<"2.1"
"input[placeholder='Owners']"<<"microsoft"
"*[placeholder='Notes']"<<"new design suite by microsoft"
click "input[value='Save']"
))
test (fun _ ->
(
let testCases=text "Test Cases"
click testCases
click "input[value='Save']"
let ApplicationFieldValidation=text "Application is required"
ApplicationFieldValidation=="Application is required"
let SuiteFieldValidation=text "Suite is required"
SuiteFieldValidation=="Suite is required"
let NameFieldValidation=text "Name is required"
NameFieldValidation=="Name is required"
))
test (fun _ ->
(
"select[name='Application']"<<"shivani"
"select[name='Suite']"<<"NewSuite"
"input[placeholder='Name']"<<"Newtestcases"
"input[placeholder='Version']"<<"3.1"
"input[placeholder='Owners']"<<"abcdef"
"*[placeholder='Notes']"<<"new testcases"
"input[placeholder='Requirements']"<<"requirements of the testcases"
"input[placeholder='Steps']"<<"Steps of the testcases"
"input[placeholder='Expected']"<<"Expected outcome from the testcases"
"input[placeholder='History']"<<"History"
"input[placeholder='Attachments']"<<"Attachments"
click "input[value='Save']"
))
test (fun _ ->
(
let testrun=text "Test Runs"
click testrun
click "input[value='Save']"
let ApplicationFieldValidation=text "Application is required"
ApplicationFieldValidation=="Application is required"
let DescriptionFieldValidation=text "Description is required"
DescriptionFieldValidation=="Description is required"
let TestcasesFieldValidation=text "Test Cases are required"
TestcasesFieldValidation=="Test Cases are required"
))
test (fun _ ->
(
"select[name='Application']"<<"shivani"
"input[placeholder='Description']"<<"Description of the test runs"
"input[placeholder='Test Cases']"<<"Test Cases"
click "input[value='Save']"
))
run()