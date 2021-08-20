# Contact Management System

A Blazor Server application that utilizes EF Core to perform add, update, and delete operations in a local SQLite database. 

## Features
- User can add, view, edit, and delete contacts
- A confirmation modal is displayed when deleting a contact
- Contact entries include last name, first name, birth date, and phone number
- First name and last name fields are required
- First and last name may not exceed 250 characters
- Phone number may not exceed 15 characters
- Contact list can be sorted by first name and last name

## Demo
### Adding a Contact

In the below example, the user begins with an empty database. They may add a contact by selecting the "Add Contact" button and filling in the appropriate fields. Once the user selects "Save", they are re-directed to the home page where the newly created contact is displayed.

![Adding a contact](https://github.com/jsulumich/ContactManagementSystem/blob/master/Gifs/adding%20a%20contact.gif)

### Editing a Contact

A user can view and edit a contact by selecting "Edit/View" in the contact's column. In the below example, the user modifies the contact's last name and phone number. After the user selects "Save", the contact is updated and the change is reflected in the home page table.

![Editing a contact](https://github.com/jsulumich/ContactManagementSystem/blob/master/Gifs/edit%20a%20contact.gif)

### Deleting a Contact

A user can delete a contact by selecting "Edit/View" in the contact's column. Once the user selects "Delete", a modal is displayed asking the user to confirm. If the user selects "No", the modal is closed. If the user selects "Yes", the contact is deleted and the change is reflected in the home page table.

![Deleting a contact](https://github.com/jsulumich/ContactManagementSystem/blob/master/Gifs/delete%20contact.gif)

### Sorting Contacts

The user can sort the list of contacts by first or last name, in both ascending and descending order.

![Sorting contacts](https://github.com/jsulumich/ContactManagementSystem/blob/master/Gifs/sorting%20contacts.gif)

### Data Validation

A contact cannot be saved unless the first and last name fields are populated. Additionally, the phone number of a contact cannot exceed 15 characters. In the example below, the user attempts to update a contact to an invalid state, and the program displays the related errors messages. Selecting "Cancel" returns the user to the home page without modifying any data values.

![Validation](https://github.com/jsulumich/ContactManagementSystem/blob/master/Gifs/validation.gif)
