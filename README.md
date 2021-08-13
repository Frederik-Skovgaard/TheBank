# Introduction
This is a console based project, that aims to simulate a bank.

The purpose of this project is to show, that i can document my projects

# Links
### Change Log Updates
[Bank 1](#[Bank-1])

[Bank 2](#[Bank-2])

[Bank 3](#[Bank-3])

[Bank 4](#[Bank-4])

[Bank 5](#[Bank-5])

# Menu
### Vælg venligst

#### m = menue 
- Dosen't have a function yet

#### k = Konto oprettes 
- Create a new account

#### i = Indsæt
- Deposit money into selected account

#### h = Hæv beløb
- Withdraw money from selected account

#### r = Rentetilskrivning
- Go threw all account and add/withdraw interest

#### s = Vis saldo
- Show the balance of selected account

#### b = Vis bank
- Show the collected balance in the bank

## Method used
### CreateAccount()
- CreateAccount method uses parameters Name & AccountType

- from that adds the new account to an Account list



### Deposit()
- Deposit Method finds the account with the use of its parameter accountNum

- from that it takes the account balance and adds the amount parameter



### Withdraw()
- Withdraw Method finds the account with the use of its parameter accountNum

- from that it take the account balance and subtracts the amount parameter



### ShowBalance()
- ShowBalance Method finds the account with its use of its paraneter accountNum

- from that it can take the specific accounts balance and return a string



### ChargeInterest()
- ChargeInterest Method runs threw the account list and subtract/adds 

- money according to this sheet

> Checking Account: an account that give 0.5% in interest no matter the circumstances

> Savings Account: a savings account that give
> * 1% if balance is under 50 000 Kr.
> * 2% if balance is under 100 000 Kr.
> * 3% if balance is over 100 000 Kr.

> Consumer Account: a accoount give 0,1% interest, but cost 20% if balance is negetiv


# Changelog
All notable changes to this project will be documented in this file.

# [Unreleased]

## [Bank 1] - 11-08-21
### Added
- [x] Create Account.
- [x] Create menue.
- [x] Create Bank.



## [Bank 2] - 11-08-21
### Added
- [x] Use methods for the new bank menu.
- [x] made a new menu with more options.

### Removed
- [x] Old bank menu



## [Bank 3] - 12-08-21
### Added
- [x] Method for showing all money in the bank.
- [x] Account counter.
- [x] list with all Accounts.
- [x] Account nummbers.


### Changed
- [x] Change menu to fit with new functionalitys.



## [Bank 4] - 12-08-21
### Added
- [x] Add interest rates to specific account types 
- [x] Add account types 

### Changed
- [x] Add new option on bank menu
- [x] Change account class to an abstract
- [x] Change CreateAccount method to take account type

### Removed 
- [x] Account constructoren removed
 

## [Bank 5] - 12-08-21
### Added
- [x] Enum Account Type add
- [x] Add folder BLL & Copy Bank.cs over to folder 
- [ ] Make Account item list
- [ ] Add IBank in folder repository 

### Change
- [x] Change CreateAccount Method to choose enum AccountType 
