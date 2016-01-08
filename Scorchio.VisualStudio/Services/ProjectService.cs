﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the ProjectService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Scorchio.VisualStudio.Services
{
    using EnvDTE;
    using EnvDTE80;
    using Extensions;
    using Interfaces;
    using Scorchio.VisualStudio.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using VSLangProj;

    /// <summary>
    /// Defines the ProjectService type.
    /// </summary>
    public class ProjectService : IProjectService
    {
        /// <summary>
        /// The project.
        /// </summary>
        private readonly Project project;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectService" /> class.
        /// </summary>
        /// <param name="project">The project.</param>
        public ProjectService(Project project)
        {
            this.project = project;
        }

        /// <summary>
        /// Gets the project.
        /// </summary>
        public Project Project 
        { 
            get { return this.project; } 
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name 
        { 
            get { return this.project.Name; } 
        }

        /// <summary>
        /// Gets the DTE service.
        /// </summary>
        public IDTEService DTEService
        {
            get
            {
                DTE2 dte2 = this.project.DTE as DTE2;
                return new DTEService(dte2);
            }
        }

        /// <summary>
        /// Gets the project path.
        /// </summary>
        /// <returns>The project path.</returns>
        public string GetProjectPath()
        {
            return this.project.GetProjectPath();
        }

        /// <summary>
        /// Gets the project items.
        /// </summary>
        /// <returns> The project items.</returns>
        public IEnumerable<IProjectItemService> GetProjectItems()
        {
            IEnumerable<ProjectItem> items = this.project.GetProjectItems();

            return items.Select(projectItem => new ProjectItemService(projectItem))
                .Cast<IProjectItemService>().ToList();
        }

        /// <summary>
        /// Gets the c# project items.
        /// </summary>
        /// <returns>The project items.</returns>
        public IEnumerable<IProjectItemService> GetCSharpProjectItems()
        {
            IEnumerable<ProjectItem> items = this.project.GetCSharpProjectItems();

            return items.Select(projectItem => new ProjectItemService(projectItem))
                .Cast<IProjectItemService>().ToList();
        }

        /// <summary>
        /// Gets the project item.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// The project item.</returns>
        public IProjectItemService GetProjectItem(string fileName)
        {
            ProjectItem projectItem = this.project.GetProjectItem(fileName);

            return projectItem != null ? new ProjectItemService(projectItem) : null;
        }

        /// <summary>
        /// Gets the folder.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <returns>The folder.</returns>
        public IProjectItemService GetFolder(string folderName)
        {
            ProjectItem projectItem = this.project.GetFolder(folderName);

            return projectItem != null ? new ProjectItemService(projectItem) : null;
        }

        /// <summary>
        /// Gets the project references.
        /// </summary>
        /// <returns>
        /// The project references.</returns>
        public IEnumerable<Reference> GetProjectReferences()
        {
            return this.project.GetProjectReferences();
        }

        /// <summary>
        /// Adds the project reference.
        /// </summary>
        /// <param name="referencedProjectService">The referenced project service.</param>
        /// <returns>The reference.</returns>
        public Reference AddProjectReference(IProjectService referencedProjectService)
        {
            return this.project.AddProjectReference(referencedProjectService.Project);
        }

        /// <summary>
        /// Adds to folder from template.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>True or False.</returns>
        public bool AddItemToFolderFromTemplate(
            string templateName, 
            string fileName)
        {
            return this.project.AddItemToFolderFromTemplate(
                templateName,
                fileName);
        }

        /// <summary>
        /// Adds the project to folder from template.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="path">The path.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>True or False.</returns>
        public bool AddProjectToFolderFromTemplate(
            string templateName, 
            string path,
            string fileName)
        {
            return this.project.AddProjectToFolderFromTemplate(
                templateName,
                path,
                fileName);
        }

        /// <summary>
        /// Adds to folder from file.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>True or False.</returns>
        public ProjectItem AddToFolderFromFile(
            string folderName, 
            string fileName)
        {
            return this.project.AddToFolderFromFile(
                folderName,
                fileName);
        }

        /// <summary>
        /// Adds the reference.
        /// </summary>
        /// <param name="destinationFolder">The destination folder.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="source">The source.</param>
        public void AddReference(
            string destinationFolder, 
            string destination, 
            string source)
        {
            this.project.AddReference(
                destinationFolder,
                destination,
                source);
        }

        /// <summary>
        /// Saves all.
        /// </summary>
        public void SaveAll()
        {
            DTE2 dte2 = this.project.DTE as DTE2;
            dte2.SaveAll();
        }

        /// <summary>
        /// Writes the status bar message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void WriteStatusBarMessage(string message)
        {
            DTE2 dte2 = this.project.DTE as DTE2;
            dte2.StatusBar.Text = message;
        }

        /// <summary>
        /// Gets the folder items.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="withFileExtensions">if set to <c>true</c> [with file extensions].</param>
        /// <returns>The folder items.</returns>
        public IEnumerable<string> GetFolderItems(
            string folderName, 
            bool withFileExtensions)
        {
            return this.project.GetFolderItems(folderName, withFileExtensions);
        }

        /// <summary>
        /// Removes the reference.
        /// </summary>
        /// <param name="referenceName">Name of the reference.</param>
        public void RemoveReference(string referenceName)
        {
            this.project.RemoveReference(referenceName);
        }

        /// <summary>
        /// Removes the references.
        /// </summary>
        /// <param name="value">The value.</param>
        public void RemoveReferences(string value)
        {
            this.project.RemoveReferences(value);
        }

        /// <summary>
        /// Removes the folder.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <returns>The projectItem Service.</returns>
        public IProjectItemService RemoveFolder(string folderName)
        {
            ProjectItem projectItem = this.project.RemoveFolder(folderName);

            return projectItem != null ? new ProjectItemService(projectItem) : null;
        }

        /// <summary>
        /// Removes the folder item.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="itemName">Name of the item.</param>
        public void RemoveFolderItem(
            string folderName, 
            string itemName)
        {
            IProjectItemService projectItemService = this.GetFolder(folderName);

            if (projectItemService != null)
            {
                IEnumerable<ProjectItem> projectItems = projectItemService.GetSubProjectItems();

                ProjectItem projectItem = projectItems.FirstOrDefault(x => x.Name.Contains(itemName));

                if (projectItem != null)
                {
                    projectItem.RemoveAndDelete();
                }
            }
        }

        /// <summary>
        /// Removes the folder item.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        public void RemoveFolderItem(string itemName)
        {
            IEnumerable<IProjectItemService> projectItems = this.GetProjectItems();

            IProjectItemService projectItemService = projectItems.FirstOrDefault(x => x.Name.Contains(itemName));

            if (projectItemService != null)
            {
                projectItemService.RemoveAndDelete();
                return;
            }

            foreach (IProjectItemService subProjectItemService in this.GetProjectItems())
            {
                if (subProjectItemService.Kind == VSConstants.VsProjectItemKindPhysicalFolder)
                {
                    IEnumerable<ProjectItem> items = subProjectItemService.GetSubProjectItems();

                    ProjectItem projectItem  = items.FirstOrDefault(x => x.Name.Contains(itemName));

                    if (projectItem != null)
                    {
                        projectItem.RemoveAndDelete();
                        return;
                    }
                }
            }

            /*foreach (IProjectItemService subProjectItemService in projectItems.)
            {
                foreach (var VARIABLE in subProjectItemService)
                {
                    
                }
                ////subProjectItemService.RemoveAndDelete();
                ////return;
            }

            IEnumerable<IProjectItemService> subProjectItems = this.GetFolderProjectItems();

            foreach (IProjectItemService subFolderItemService in subProjectItems)
            {
                if (subFolderItemService.Name.Contains(itemName))
                {
                    subFolderItemService.RemoveAndDelete();
                    return;
                }
            }

            IEnumerable<IProjectService> subProjectServices = this.GetSubProjects();

            foreach (IProjectService subProjectService in subProjectServices)
            {
                IEnumerable<IProjectItemService> projectItemServices = subProjectService.GetProjectItems();

                foreach (IProjectItemService itemService in projectItemServices)
                {
                    if (itemService.Name.Contains(itemName))
                    {
                        itemService.RemoveAndDelete();
                        return;
                    }
                }
            }*/
        }

        /// <summary>
        /// Gets the sub projects.
        /// </summary>
        public IEnumerable<IProjectService> GetSubProjects()
        {
            IEnumerable<Project> items = this.project.GetSubProjects();

            return items.Select(projectItem => new ProjectService(projectItem))
                .Cast<IProjectService>().ToList();
        }

        /// <summary>
        /// Gets the sub folders.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        public IEnumerable<IProjectItemService> GetSubFolders(string folderName)
        {
            IEnumerable<ProjectItem> items = this.project.GetSubFolders(folderName);

            return items.Select(projectItem => new ProjectItemService(projectItem))
                .Cast<IProjectItemService>().ToList();
        }

        /// <summary>
        /// Gets the folder project items.
        /// </summary>
        public IEnumerable<IProjectItemService> GetFolderProjectItems()
        {
            IEnumerable<ProjectItem> items = this.project.ProjectItems.Cast<ProjectItem>()
                .Where(x => x.Kind == VSConstants.VsProjectItemKindPhysicalFolder);

            return items.Select(projectItem => new ProjectItemService(projectItem))
                    .Cast<IProjectItemService>().ToList();
        }

        /// <summary>
        /// Gets the folder or create.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        public IProjectItemService GetFolderOrCreate(string folderName)
        {
            ProjectItem projectItem = this.project.GetFolder(folderName) ?? this.project.ProjectItems.AddFolder(folderName);

            return new ProjectItemService(projectItem);
        }

        /// <summary>
        /// Adds the text template.
        /// </summary>
        /// <param name="textTemplateInfo">The text template information.</param>
        /// <returns></returns>
        public string AddTextTemplate(TextTemplateInfo textTemplateInfo)
        {
            string output = this.project.AddTextTemplate(
                textTemplateInfo.ProjectFolder, 
                textTemplateInfo.FileName, 
                textTemplateInfo.TextOutput);

            if (textTemplateInfo.ChildItem != null)
            {
                this.project.AddTextTemplate(
                    textTemplateInfo.ChildItem.ProjectFolder,
                    textTemplateInfo.ChildItem.FileName,
                    textTemplateInfo.ChildItem.TextOutput);
            }

            return output;
        }
    }
}
