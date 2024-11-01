# University of Piraeus  
## Department of Informatics  

### Project  
**"Rapid Application Development"**

**Romanos Sarantidis, ID: ΜΠΠΛ2327**

**Piraeus 2024**

---

### Project Structure
The project consists of three main forms:

- **Main Form (Addressbook)**
- **Contact Display Form** (shows each contact's name)
- **Add Contact Form** 

---

### Addressbook

**Functionality:**  
Displays all contacts and allows the user to search by name or by the group to which the contact belongs (Family, Friend, Work).

**Connectivity:**  
The main form communicates with all other forms and provides an option to exit the program.

**Features:**
1. View a list of all contacts.
2. Display contact details (accessible with a double-click on the contact, as indicated by a label).
3. Search for a contact by name.
4. Search for a contact by the group (Family, Friend, Work).
5. Add a new contact in a new window.
6. Exit the program.

---

### Contact Search

- **By Name (Right-Side):**  
  The program communicates with the database and returns search results. This search is flexible and is case-insensitive. The contact list updates in real-time as each character is entered.

- **By Group (Left-Side):**  
  An additional feature designed to improve user experience and expedite contact location. Contacts are grouped based on the nature of the relationship (Family, Work, Friend) and can be displayed by selecting the respective group. To prevent conflicts, when one search mode is active, the other is disabled, and the full contact list reappears.

---

### Show Contact

The contact display form (activated by double-clicking the desired contact in the main screen contact list) includes the following contact details: name, phone number, address, email, date of birth, and group.

**Details:**
1. Name
2. Phone Number
3. Address
4. Email
5. Date of Birth
6. Contact Group
7. Delete Contact
8. Exit and return to the main screen

All fields are editable and can be updated by double-clicking on the desired field.  

**Editing Options (Left-Side):**
1. Change Name (text input)
2. Change Date of Birth (date input)
3. Change Contact Group (drop-down list)
4. Save Changes and Close Form (appears when editing is selected by double-clicking)

**Connectivity:**  
The contact display form only communicates with the main form, with an option to exit.

---

### Add Contact

**Functionality:**  
Allows the user to add a new contact to the list. After filling in the necessary details, the user can save the new contact and return to the main form by selecting the corresponding icon.

**Form Elements:**
1. Basic Contact Information
2. Contact Group
3. Save and Close Add Contact Form
4. Exit the Form Without Saving

**Connectivity:**  
The form only communicates with the main form upon closing.

---

### Interactions

All interactive elements in the program that the user can engage with are highlighted by cursor changes, explanatory labels, and color shifts.

Whenever an option to exit is selected or if any unsaved changes or added contact details are at risk of being lost, the user is notified with a prompt.
