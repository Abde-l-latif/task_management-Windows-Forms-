https://github.com/user-attachments/assets/795b12ed-9be8-4768-90fa-454ba29afba1

# To-Do List Application (Windows Forms)



A simple To-Do List application built with C# and Windows Forms.  
It allows you to add, track, and manage tasks with persistent storage in a text file.

---

## Features

- **Add tasks** with optional completed status.
- **Mark tasks as completed** using checkboxes.
- **View all tasks** or filter to show only completed tasks.
- **Delete tasks** from a separate form.
- **Persistent storage**: Tasks are saved to `tasks.txt` and loaded automatically on startup.
- **Multiple forms**: Main form and Delete Task form for better task management.

---

## How It Works

1. **Adding a task:**  
   - Enter text in the input field and click **Add**.
   - Task is saved to `tasks.txt` in the format:  
     ```
     Task Text|true/false
     ```
   - `true` if completed, `false` otherwise.

2. **Viewing tasks:**  
   - Click **All Tasks** to display all tasks in the checklist.  
   - Click **Completed** to display only checked tasks.

3. **Marking tasks as completed:**  
   - Check or uncheck the box next to a task.
   - The app automatically updates `tasks.txt` to reflect the new status.

4. **Deleting a task:**  
   - Open the **Delete Task** form.
   - Enter the task number to delete it.
   - Task is removed from `tasks.txt` permanently.

---

## File Structure

to_do_list/
├─ Form1.cs # Main form
├─ Form2.cs # Delete task form
├─ Program.cs # Entry point
├─ tasks.txt # Persistent task storage
├─ Form1.Designer.cs
├─ Form2.Designer.cs
└─ Properties/

yaml
Copy code
