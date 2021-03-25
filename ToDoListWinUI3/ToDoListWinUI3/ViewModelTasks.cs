using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Graphics.Display;
using ToDoListWinUI3;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace ToDoListWinUI3
{
    public class ViewModelTasks : ViewModelBase
    {
        public ViewModelTasks()
        {

        }
        public ObservableCollection<ModelTask> Tasks { get; set; } = new ObservableCollection<ModelTask>()
        {
            new ModelTask() { Title = "This is the title 1", Body = "Some text about a task 1", isDone = true },
            new ModelTask() { Title = "This is the title 2", Body = "Some text about a task 2", isDone = false },
            new ModelTask() { Title = "This is the title 3", Body = "Some text about a task 3", isDone = false },
            new ModelTask() { Title = "This is the title 4", Body = "Some text about a task 4", isDone = true },
            new ModelTask() { Title = "This is the title 5", Body = "Some text about a task 5", isDone = false },
            new ModelTask() { Title = "This is the title 6", Body = "Some text about a task 6", isDone = true },
            new ModelTask() { Title = "This is the title 7", Body = "Some text about a task 7", isDone = false },
        };

        private string taskDescription;
        public string TaskDescription { get => taskDescription; set => SetProperty(ref taskDescription, value); }
        private string taskTitle;
        public string TaskTitle { get => taskTitle; set => SetProperty(ref taskTitle, value); }

        private ICommand addTaskCommand;
        public ICommand AddTaskCommand => addTaskCommand ??= new TaskCommand(AddTask);

        private void AddTask()
        {
            Debug.WriteLine("Работает добавление");
            if (!string.IsNullOrEmpty(TaskTitle))
            {
                Tasks.Add(new ModelTask() { Title = TaskTitle, Body = TaskDescription, isDone = false });
            }
        }

        private ICommand removeLastTaskCommand;
        public ICommand RemoveLastTaskCommand => removeLastTaskCommand ??= new TaskCommand(RemoveLastTask);

        private void RemoveLastTask()
        {
            if (Tasks.Count != 0)
            {
                Debug.WriteLine("Работает удаление");
                Tasks.RemoveAt(Tasks.Count - 1);
            }
        }
    }
}
