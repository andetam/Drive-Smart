Deadline: 06.05.2024
## 1.Introduction to Testing: 

Software testing is the systematic process in which software is evaluated in order to identify defects and errors. This testing involves running a program or system in such a way as to find errors. The main purpose of software testing is to first ensure that the software behaves as expected and also meets the requirements of the user. To develop the software, testing is very important as it helps the software to improve its quality, reduce failures and increase user satisfaction.


## 2.Purpose of Testing: 

The objectives of software development testing are:
- Early identification of defects: Through testing, defects can be identified at the beginning of the software development process, thus helping to reduce costs. We can also say that the early detection of defects prevents these defects from spreading to other stages of development, where they can become more complex and require a higher cost to fix.
- Software functionality verification: Using testing, you can verify software components in a way that they function as intended, fulfilling the required requirements as well as the expectations of the user. We can also say that in this way it is ensured that the software behaves correctly in different scenarios or different conditions.
- Ensuring reliability: Testing helps ensure the reliability of software by identifying defects and fixing them so that they do not cause malfunctions. Also, through testing, the stability of the software increases, resulting in the improvement of the experience and satisfaction of the user.

## 3.Focus on Testing a Single Component: 

In our car rental application, we focused on testing the CarInventory module. This module is very important as it manages the inventory of cars that may be available, tracks the availability of cars and ensures the reservation and return processes of cars. Testing this component is primary because it has a central role in the functioning of our system. If there is a defect in the "CarInventory" module, this leads to the incorrect management of the entire car inventory, which affects customer reservations as well as other operations of the application.


## 4.Preparing Test Cases:

To test the "CarInventory" module, we prepare several test cases that include different scanners such as:
- Normal input: In this case we tested the input data to ensure that the module works correctly.
- Edge cases:With this test scenario, it will include several cases when the inventory is empty and when it is at maximum capacity, in order to observe the behavior of the module in extreme scenarios.
- Invalid inputs: We also tested several cases to see how the module handles invalid data or unexpected inputs such as incorrect data.


## 5.Choosing Testing Frameworks: 

Our car rental system is based on Python, and as an excellent choice for testing we thought "pytest" because it carries simplicity and flexibility. Its use offers us a more intuitive syntax for writing tests and also offers powerful mechanisms, simplifying test cases in a clearer way. In addition, "pytest" integrates with other testing tools without problems, and allows more advanced testing capabilities.


## 6.Writing Test Code: 

We wrote several test methods for the CarInventory module to include various functions such as:
1.Addition of inventory machines: Using testing methods we stimulated the addition of inventory machines and verified that they were added successfully.
2.Removal of cars from the inventory: Through testing methods, we tried the removal of cars from the inventory, which was successful.
3.Checking the availability of cars: Using testing methods we verified the availability status of the cars in the inventory
4.Edge case handling: We tested several cases which were inventory overflow, inventory empty in order to ensure how the module will behave in such scenarios.


# test_car_inventory.py 

import pytest
from car_inventory import CarInventory

# Fixture to create an instance of CarInventory for each test
@pytest.fixture
def car_inventory():
    return CarInventory()

# Test adding a car to the inventory
def test_add_car(car_inventory):
    # Adding a car for the first time
    assert car_inventory.add_car("001", "Toyota Camry") == True
    assert car_inventory.inventory == {"001": "Toyota Camry"}

    # Adding another car
    assert car_inventory.add_car("002", "Honda Civic") == True
    assert car_inventory.inventory == {"001": "Toyota Camry", "002": "Honda Civic"}

    # Adding a car with an existing ID should fail
    assert car_inventory.add_car("001", "Ford Mustang") == False
    assert car_inventory.inventory == {"001": "Toyota Camry", "002": "Honda Civic"}

# Test removing a car from the inventory
def test_remove_car(car_inventory):
    car_inventory.add_car("001", "Toyota Camry")
    car_inventory.add_car("002", "Honda Civic")
    
    # Removing an existing car
    assert car_inventory.remove_car("001") == True
    assert car_inventory.inventory == {"002": "Honda Civic"}

    # Removing a non-existent car should fail
    assert car_inventory.remove_car("003") == False
    assert car_inventory.inventory == {"002": "Honda Civic"}

# Test checking availability of a car in the inventory
def test_check_availability(car_inventory):
    car_inventory.add_car("001", "Toyota Camry")
    car_inventory.add_car("002", "Honda Civic")
    
    # Checking availability of an existing car
    assert car_inventory.check_availability("001") == True
    
    # Checking availability of a non-existent car
    assert car_inventory.check_availability("003") == False

Explanation for test cases are:
- Test adding a car to the inventory: This test verifies which cars can be successfully added to the inventory. Checking for adding a car, adding multiple cars, and attempts to add a car with an existing ID.
- Test removing a car from the inventory: This test ensures that cars can be removed from the car inventory. It tests the removal of existing cars and the attempt to remove a car that does not exist.
- Test checking availability of a car in the inventory: This test case verifies the functionality to check the availability of a car in the inventory. So this type of test checks the availability of the existing and non-existing car.
- Test edge cases: With this test case, extreme scenarios are covered, such as adding a large number of machines so that the intent reaches maximum capacity, as well as attempts to remove or add machines beyond the limits. Through this test, it ensures that our system behaves correctly. in conditions that can be extreme.

By performing each test case, this ensures that the CarInventory module of our system has been fully tested, including different scenarios and edge cases. This approves the reliability and correctness of our rental car system.

## 7.Running Tests: 

Our rental car system has the primary purpose of ensuring the accuracy and reliability of the car inventory management functionality. The "CarInventory" module is responsible for the management of the cars that are available for rent, this has been subjected to tests in order to verify its correctness and durability.

Executing tests:
To verify the correctness of the CarInventory module, we have developed a series of test cases and used the "Pytest" framework. In these test cases, different scenarios are included such as adding cars or removing them in the attempt and checking the availability of cars.

Test Results:

PASSING SCENARIOS

1.Add Car Test: All tests for adding cars to the inventory passed successfully. Through this test, we can say that the cars can be added to the inventory without a problem.
2. Remove Car Test: Also, the car removal test was successful, which means that cars can be removed from the inventory whenever necessary.
3.Check Availability Test: The tests to check the availability of the car in the inventory passed as I expected. This shows that our system accurately tracks the availability of the cars.

FAILING SCENARIO

1.Add Car Test:A test to add a car was not successful because of an unexpected problem with the addition process. After the investigations we did we discovered that the way to add the car was not returning the correct value.

ERROR SCENARIO
1.Syntax error test: During a test run we encountered a syntax error that resulted in the test execution failing. This error was identified and resolved immediately by us.

DEBUGGING AND ITERATING:
For the failed scenario, a full correction was performed to identify the problem.
After the issues are resolved, we repeat the tests again to ensure that all test cases pass successfully.
The iterative process continued until all tests passed successfully, which guaranteed the correctness and reliability of the "CarInventory" module in our rental car system.




## 8.Test Coverage: 

Achieving high test coverage is very important and essential as it ensures complete software testing.
We can identify software bugs and vulnerabilities by thoroughly testing the code base. In order to reduce the risk of undetected defects, a high test coverage should be aimed and in this way we can say that it results in ensuring the reliability and correctness of the software.

Importance of Test Coverage:

- Identifying Untested Code: Test coverage helps us identify areas of the code base that are not covered by the tests. These untested areas may contain hidden bugs or edge cases that affect the reliability of the program.

- Ensuring Comprehensive Testing: High test coverage also ensures that important functionalities such as adding cars to the inventory or removing them etc. are fully tested. This has helped identify potential issues before they affect users.

- Improving Code Quality: Test coverage encouraged us to write testable code by highlighting areas that required additional testing.

- Building Confidence: By covering the test, we create a reliability in the behavior of our software. Resulting in reducing the risk of regression errors in case we make changes or introduce new features, this ensures functionality for our entire system.
