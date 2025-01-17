# BUG_ID001

/TITLE

When we are creating a timesheet the days field is a dropdown, but this gets converted to a text field when editing a timesheet

/DETAILS

Environment: CODAT_PRODUCTION

Branch: prod

Build: Prod

Process/console: -

User: Non-logged in

Severity: Medium 

Priority: Medium

URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit?Timesheetid=a76789a8-7528-492f-b583-556f017d54f4

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter correct Employee ID, hourly rate, day, hours and minutes twice (bug when we enter a single day, raised separately) (Observe that the day is a dropdown)
4.	‘Click Save’ to save the timesheet
5.	Go to Homepage
6.	Click on Details for the timesheet we have created
7.	At the bottom of the screen click ‘Edit’

/EXPECTED

Day field should be dropdown to keep it consistent with other screens with the same input

/ACTUAL

Day field is now a text field and not a dropdown

/Event Viewer errors


/F12 IE Debugger errors


/Screenshots




 
# BUG_ID002

/TITLE

Adding a large Hourly rate number display the number in a large number format as the field has no max/min limits (I.e. 23232777655555555343333333)

/DETAILS

Environment: CODAT_PRODUCTION

Branch: prod

Build: Prod

Process/console: -

User: Non-logged in

Severity: Medium 

Priority: Medium

URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit?Timesheetid=2edac1a2-103d-45d7-b314-2aacbdf1baee 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter correct Employee ID, day, hours and minutes twice (bug when we enter a single day, raised separately) 
4.	For the Hourly rate enter: 23232777655555555343333333
5.	‘Click Save’ to save the timesheet 
6.	You will land on Details page: observe that the number has changed to a large number representation (2.3232777E+25) 

/EXPECTED

The actual number enter should be displayed or a hourly rate max and min should be set on the field

/ACTUAL

No Min/Max validation added to the field 

/Event Viewer errors


/F12 IE Debugger errors


/Screenshots

 

# BUG_ID003

/TITLE

Whilst adding or editing an existing timesheet, adding a new timesheet does not store the added timesheet – you need to click on (+) button to add a new empty row to then add the item

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: High 
Priority: High
URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit?Timesheetid=2edac1a2-103d-45d7-b314-2aacbdf1baee 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter Employee id and hourly rate only, observe that we get a ‘Development mode’ error
4.	Enter employee id, hourly rate and a single row for day, hours, minutes, observe that we get a ‘Development mode’ error
5.	Enter correct Employee ID, hourly rate, day, hours and minutes and click on the (+) for an empty row 
6.	‘Click Save’ to save the timesheet 
7.	Observe that the timesheet is now added 

/EXPECTED

We should not need an empty timesheet row to successfully add a timesheet

/ACTUAL

On create and edit timesheet pages we get a development error when we try adding a timesheet without a empty timesheet row

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots



# BUG_ID004

/TITLE

When we get to display screen to see the details for timesheet added, we have the hourly rate label as $ but next to the value entered we have a different currency symbol i.e. £, I have seen some timesheets display Yen symbol, seems randomly selected as there is no selection for user to select currency. 

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: Medium
Priority: High
URL: https://codat-qa-task.azurewebsites.net/Details?timesheetId=190c2be1-421b-43ba-82c6-fd4bb5885475

/STEPS
1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter correct Employee ID, hourly rate, day, hours and minutes and click on the (+) for an empty row 
4.	‘Click Save’ to save the timesheet 


/EXPECTED
Should be no contradiction between currency symbol of label ($) and the value symbol (£)

/ACTUAL
Observe contradiction between currency symbol of label ($) and the value symbol (£)

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots
 


# BUG_ID005

/TITLE

When creating a new timesheet, removing button (-) does not work, but does work when editing a timesheet

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: Medium
Priority: High
URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter correct Employee ID, hourly rate, day, hours and minutes and click on the (+) for an empty row 
4.	Enter another row and populate 
5.	Click on add (+) another row so you end up with 3 rows
6.	Click on (-) to remove item


/EXPECTED

Should be able to remove added items on create timesheet page

/ACTUAL

Cannot remove items when first creating a timesheet

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots










# BUG_ID006

/TITLE

No known limits set to number of items to be added for a timesheet, can create a memory leak if persistently adding items 

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: High
Priority: High
URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter correct Employee ID, hourly rate, day, hours and minutes and click on the (+) for an empty row 
4.	Enter another row and populate 
5.	Click on add (+) another row so you end up with 3 rows
6.	Keep adding items 


/EXPECTED

No requirements on this specified and user is able to add as many items as possible but should be limited to avoid memory leaks

/ACTUAL

No requirements on this specified and user is able to add as many items as possible but should be limited to avoid memory leaks

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots











# BUG_ID007

/TITLE

Negative numbers allowed for minutes, hours, employee id and hourly rate fields when we are creating or editing timesheets, the employee ID field also allows incorrect NON-ASCII characters (¶�)

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: High
Priority: High
URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter negative numbers for minutes, hours, employee id and hourly rate fields 
4.	Enter incorrect character for Employee id field
5.	Click on ‘Save’

/EXPECTED

No negative numbers should be allowed for these fields 
Employee ID field should not allow incorrect NON-ASCII characters (¶�)

/ACTUAL

All minutes, hours, employee id and hourly rate fields allow negative numbers 
Employee ID field allows incorrect NON-ASCII characters (¶�)

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots









# BUG_ID008

/TITLE

On creating and editing a timesheet we allow hours more than 24 and minutes more than 60 with no validation for each day

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: High
Priority: High
URL: https://codat-qa-task.azurewebsites.net/CreateOrEdit 

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Click on ‘Create New’
3.	Enter a number more than 24 for hours and more than 59 for minutes
4.	Click on ‘Save’

/EXPECTED

Should not allowed more than 24 hours and more than 59 minutes to be entered for each day 

/ACTUAL

No validation around hours/minutes on each day entered

/Event Viewer errors

/F12 IE Debugger errors

/Screenshots



# BUG_ID009

/TITLE

When we are deleting a timesheet for id '9133f2b3-af08-4812-b23b-8e513adb2595’ we are asked to confirm for a timesheet with a different id 'b7f25fcd-3257-4a7f-a103-a4e1cedfa7bb' 

/DETAILS

Environment: CODAT_PRODUCTION
Branch: prod
Build: Prod
Process/console: -
User: Non-logged in
Severity: High
Priority: High
URL: https://codat-qa-task.azurewebsites.net/Delete  

/STEPS

1.	Go to https://codat-qa-task.azurewebsites.net/ 
2.	Select a timesheet and take note of the id
3.	Click on Delete for the same item
4.	On delete screen compare the ids from previous page

/EXPECTED	

GUID ids should match on homepage compared to the delete confirmation page

/ACTUAL

GUIDs do not match when deleting a timesheet

/Event Viewer errors


/F12 IE Debugger errors


/Screenshots



# Other possible bugs to investigate:

1. adding a single timesheet day throws an error (related to BUG_ID003)
2. adding a timesheet with same id is allowed - should this be allowed?
