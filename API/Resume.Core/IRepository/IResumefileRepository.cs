using Resume.Core.Models;

namespace Resume.Core.IRepository
{
    public interface IResumefileRepository
    {
        ResumeFile GetResumeFileById(int id);
        List<IEnumerable<ResumeFile>> GetAllResumeFiles();
        ResumeFile AddResumeFile(ResumeFile entity);
        ResumeFile UpdateResumeFile(ResumeFile entity);
        ResumeFile DeleteResumeFile(int id);
    }
}