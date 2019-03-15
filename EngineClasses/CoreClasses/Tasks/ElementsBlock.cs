using System.Collections.Generic;

namespace EngineClasses.CoreClasses.Tasks
{
    public class MElementsBlock : IEnumerable<Tasking>
    {
        List<Tasking> tasks = new List<Tasking>();
        public MElementsBlock()
        {
            tasks.AddRange(new Tasking[] { new NonAdaptedTask(), new AdaptingTask(), new RegulatingTask() });
        }
        public void AddTask(Tasking task)
        {
            tasks.Add(task);
        }
        public Tasking this[int index]
        {
            get { return (Tasking)tasks[index]; }
            set { tasks[index] = value; }
        }

        public IEnumerator<Tasking> GetEnumerator()
        {
            return tasks.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return tasks.GetEnumerator();
        }
    }
}
