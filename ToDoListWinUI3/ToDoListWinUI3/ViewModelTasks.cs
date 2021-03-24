using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Graphics.Display;

namespace ToDoListWinUI3
{
    public class ViewModelTasks
    {
        public ICommand UpdateData;
        public ICommand ReadData;
        public ViewModelTasks()
        {
            UpdateData = new TaskCommand(() => { /* Write data */ });
            ReadData = new TaskCommand(() => { /* Read data */ });
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
    }
}
