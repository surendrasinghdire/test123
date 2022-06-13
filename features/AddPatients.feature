Feature: AddPatients
	Add the patients

@admitpatient
Scenario Outline: user can add patients
	Given No patient is admitted
	And Hemo Application is launched
	When user admits and starts a patient with <lastname> and <firstname> and <MRN> and <weight> and <height>
	Then user verifies that the task of the philips Hemodynamic application is set to monitoring
	And user verifies the default layout for the procedure is applied
Examples:
| lastname | firstname | MRN | weight   | height     |
| Alex     | John      | 11  | Test@123 | 04/04/2022 |
| kumar    | Tess      | 22  | Test@123 | 11/06/2022 |
| Kuiper   | Sam       | 33  | Test@123 | 19/01/2000 |

#And user navigated to add patient screen