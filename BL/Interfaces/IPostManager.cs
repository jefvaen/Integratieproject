﻿using Domain.Entiteit;
using Domain.Post;
using Domain.TextGain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPostManager
    {
        Task SyncDataAsync(int platformid);
        void AddPost(Post post);
        List<Post> getAllPosts();
        List<Grafiek> getAllGrafieken();
        Dictionary<string, double> BerekenGrafiekWaarde(Domain.Enum.GrafiekType grafiekType, List<Entiteit> entiteiten);
        List<Post> getRecentePosts();
        void maakVasteGrafieken();
        void addGrafiek(Grafiek grafiek);
        List<Grafiek> GetVasteGrafieken();
        void updateGrafiek(int id);
        Grafiek GetGrafiek(int id);
        void UpdateGrafiek(List<int> EntiteitIds, Grafiek grafiek);
        List<GrafiekWaarde> BerekenGrafiekWaardes(List<CijferOpties> opties, List<Entiteit> entiteiten);
    }
}
