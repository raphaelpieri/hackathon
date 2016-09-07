namespace HInfrastructure.Persistence.DataContext
{
    using HDomain.Entities;
    using Map;
    using System.Data.Entity;
    public class StoreDataContext : DbContext
    {
        public StoreDataContext()
            : base("StoreConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Pai> Pais { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<TurmaMateria> TurmaMaterias { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoMateriaTurma> AlunoMateriaTurmas { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TarefaAluno> TarefaAlunos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaiMap());
            modelBuilder.Configurations.Add(new ProfessorMap());
            modelBuilder.Configurations.Add(new TurmaMap());
            modelBuilder.Configurations.Add(new MateriaMap());
            modelBuilder.Configurations.Add(new TurmaMateriaMap());
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new AlunoMateriaTurmaMap());
            modelBuilder.Configurations.Add(new TarefaMap());
            modelBuilder.Configurations.Add(new TarefaAlunoMap());
            

        }
    }
}

