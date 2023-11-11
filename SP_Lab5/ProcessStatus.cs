namespace SP_Lab5_Priority_Planning
{
    internal class ProcessStatus
    {
        public static string NotStarted { get; } = "Не запущен";
        public static string Running { get; } = "Выполняется";
        public static string Interrupted { get; } = "Прерван";
        public static string Completed { get; } = "Выполнен";
    }
}
