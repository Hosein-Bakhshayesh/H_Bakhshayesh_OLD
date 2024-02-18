using AutoMapper;
using H_Bakhshayesh.Shared.ViewModels.BaseInformation;
using H_Bakhshayesh.Shared.ViewModels.Document;
using H_Bakhshayesh.Shared.ViewModels.Experience;
using H_Bakhshayesh.Shared.ViewModels.Message;
using H_Bakhshayesh.Shared.ViewModels.Skill;
using H_BakhshayeshModels.Models;

namespace H_Bakhshayesh.Server.Classes.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            //----------------------------------------------------------------------------------------------------------
            CreateMap<BaseInformation, BaseInformationViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<BaseInformationViewModel,BaseInformation>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //----------------------------------------------------------------------------------------------------------
            CreateMap<Document, DocumentViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<DocumentViewModel, Document>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //----------------------------------------------------------------------------------------------------------
            CreateMap<Experience, ExperienceViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<ExperienceViewModel, Experience>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //----------------------------------------------------------------------------------------------------------
            CreateMap<Message, MessageViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<MessageViewModel, Message>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //----------------------------------------------------------------------------------------------------------
            CreateMap<Skill, SkillViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<SkillViewModel, Skill>().IgnoreAllPropertiesWithAnInaccessibleSetter();

        }
    }
}
