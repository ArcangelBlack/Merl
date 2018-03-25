using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using MrelsApp.Models;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.Services.MockDataStore))]
namespace MrelsApp.Services
{
    public class MockDataStore : IDataStore<WorkoutModel>
    {
        List<WorkoutModel> items;

        public MockDataStore()
        {
            items = new List<WorkoutModel>();
            var mockItems = new List<WorkoutModel>
            {
                new WorkoutModel { Id = "b3042745-52f2-4720-b111-a373fd28d409", Text = "Warm up", Description="This is an item description."},
                new WorkoutModel { Id = "e06378a3-fc4f-46d7-a864-7e56c5074998", Text = "pectoral", Description="This is an item description." },
                new WorkoutModel { Id = "d319f22b-77cc-4432-87f0-0332399134fe", Text = "espalda", Description="This is an item description." },
                new WorkoutModel { Id = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d", Text = "biceps", Description="This is an item description." },
                new WorkoutModel { Id = "90f469e2-f9f0-4be8-9c64-942507f01855", Text = "Triceps", Description="This is an item description." },
                new WorkoutModel { Id = "15ef8077-0bd8-438f-a794-8a525ff85727", Text = "Deltoides", Description="This is an item description." },
                new WorkoutModel { Id = "f617be8e-c751-44e5-94d1-48b6d35ac41c", Text = "abdominales", Description="This is an item description." },
                new WorkoutModel { Id = "d4a54072-891b-44e6-bd1f-8bdb8251d65a", Text = "gluteos", Description="This is an item description." },
                new WorkoutModel { Id = "4af3faec-b737-4b38-978b-8bc70bc03304", Text = "Pierna", Description="This is an item description." },
                new WorkoutModel { Id = "83c6200e-cb8e-4f01-9544-fa330f170ba6", Text = "estiramientos", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(WorkoutModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(WorkoutModel item)
        {
            var _item = items.Where((WorkoutModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(WorkoutModel item)
        {
            var _item = items.Where((WorkoutModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<WorkoutModel> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<WorkoutModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public Task<IEnumerable<WorkoutModel>> GetItemsFromParentIdAsync(string parentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> Get<T>(string urlBase, string servicePrefix, string controller)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Put<T>(string urlBase, string servicePrefix, string controller, T model)
        {
            throw new NotImplementedException();
        }
    }

    public class MockSubWorkoutDataStore : IDataStore<SubWorkoutModel>
    {
        List<SubWorkoutModel> items;

        public MockSubWorkoutDataStore()
        {
            items = new List<SubWorkoutModel>();
            var mockItems = new List<SubWorkoutModel>
            {
                new SubWorkoutModel
                {
                    Id = Guid.NewGuid().ToString(),
                    ParentId = "",
                    Description = "This is an item description."
                },
                new SubWorkoutModel { ParentId ="b3042745-52f2-4720-b111-a373fd28d409", Id = Guid.NewGuid().ToString(), Description = "Cinta"},
                new SubWorkoutModel { ParentId ="b3042745-52f2-4720-b111-a373fd28d409", Id = Guid.NewGuid().ToString(), Description = "Elíptica", UrlVideo = "http://skj-tech.com/music/The_Push-Up.mp4"},
                new SubWorkoutModel { ParentId ="b3042745-52f2-4720-b111-a373fd28d409", Id = Guid.NewGuid().ToString(), Description = "Bicicleta"},
                new SubWorkoutModel { ParentId ="b3042745-52f2-4720-b111-a373fd28d409", Id = Guid.NewGuid().ToString(), Description = "Bicicleta reclinada"},
                new SubWorkoutModel { ParentId ="b3042745-52f2-4720-b111-a373fd28d409", Id = Guid.NewGuid().ToString(), Description = "remo"},
                new SubWorkoutModel
                {
                    ParentId = "e06378a3-fc4f-46d7-a864-7e56c5074998",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Chest press machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=VLDg23FqQM0&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=19"
                },
                new SubWorkoutModel
                {
                    ParentId = "e06378a3-fc4f-46d7-a864-7e56c5074998",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Butterfly machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=50cKpNDF-OU&index=20&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX"
                },
                new SubWorkoutModel
                {
                    ParentId = "e06378a3-fc4f-46d7-a864-7e56c5074998",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Bench press",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=XSza8hVTlmM&list=PLBrgqsGCyn2xQVBgDaemdoK8TJlgSpX0G&index=77"
                },
                new SubWorkoutModel
                {
                    ParentId = "e06378a3-fc4f-46d7-a864-7e56c5074998",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Apertura con mancuernas",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=xyHdY99F640"
                },
                new SubWorkoutModel
                {
                    ParentId = "e06378a3-fc4f-46d7-a864-7e56c5074998",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Press con mancuernas",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=jrDDz7x1Dpo"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Apertura con poleas",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=XnaMi2Gb_9Q"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Press con poleas",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=Ur4u1WXYLWY"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Bench press guiado",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=Aw7C1PADw84"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Bench press inclinado",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=2bKcaD7lHLs"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Bench press declinado",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=zvhNXoAhs3s"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Push up",
                    Range = "amplio",
                    Sensor = "brazo",
                    UrlVideo = "https://www.youtube.com/watch?v=_l3ySVKYVJ8"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Low row polea",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=xQNrFHEMhI4"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Pull down polea",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=UfDDlUXIRyg"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Low row machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=5VqeNOZt2ok&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=13"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Pull down machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ZbVNPTyVNTQ&index=12&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX"
                },
                new SubWorkoutModel
                {
                    ParentId = "d319f22b-77cc-4432-87f0-0332399134fe",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Pull up",
                    Range = "amplio",
                    Sensor = "brazo ",
                    UrlVideo = "https://www.youtube.com/watch?v=aAggnpPyR6E"
                },
                new SubWorkoutModel
                {
                    ParentId = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Biceps machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=d0lfsAnRFiA&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=17"
                },
                new SubWorkoutModel
                {
                    ParentId = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Biceps polea",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = " https://www.youtube.com/watch?v=7Jc4jHxax60"
                },
                new SubWorkoutModel
                {
                    ParentId = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Biceps mancuerna",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = " https://www.youtube.com/watch?v=COzFAWnbdPY"
                },
                new SubWorkoutModel
                {
                    ParentId = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Biceps barra",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = " https://www.youtube.com/watch?v=9LwedVKzjk8"
                },
                new SubWorkoutModel
                {
                    ParentId = "d2e049d0-4adb-4dad-bccb-3df6bea9ff0d",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Chin up",
                    Range = "amplio",
                    Sensor = "brazo ",
                    UrlVideo = " https://www.youtube.com/watch?v=QJGMUGaZ-vU"
                },
                new SubWorkoutModel
                {
                    ParentId = "90f469e2-f9f0-4be8-9c64-942507f01855",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Triceps machine",
                    Range = "amplio",
                    Sensor = "muñeca"
                },
                new SubWorkoutModel
                {
                    ParentId = "90f469e2-f9f0-4be8-9c64-942507f01855",
                    Id = Guid.NewGuid().ToString(),
                    Description = "press triceps machine",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=th4EY_ZMm6Y&index=5&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX"
                },
                new SubWorkoutModel
                {
                    ParentId = "90f469e2-f9f0-4be8-9c64-942507f01855",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Press francés peso libre",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=rSFXvdNnxms"
                },
                new SubWorkoutModel
                {
                    ParentId = "90f469e2-f9f0-4be8-9c64-942507f01855",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Triceps polea",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=cGEPFQ99pyQ"
                },
                new SubWorkoutModel
                {
                    ParentId = "15ef8077-0bd8-438f-a794-8a525ff85727",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Màquina elevaciones laterales",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=MsV4ftrusPQ&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=8"
                },
                new SubWorkoutModel
                {
                    ParentId = "15ef8077-0bd8-438f-a794-8a525ff85727",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Press hombro máquina",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ADWU5rYzvY4&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=3"
                },
                new SubWorkoutModel
                {
                    ParentId = "15ef8077-0bd8-438f-a794-8a525ff85727",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Elevaciones laterals mancuerna",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=ZbRaEr7yPxg"
                },
                new SubWorkoutModel
                {
                    ParentId = "15ef8077-0bd8-438f-a794-8a525ff85727",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Elevaciones frontales mancuerna",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=PJvMLaKOw0g"
                },
                new SubWorkoutModel
                {
                    ParentId = "15ef8077-0bd8-438f-a794-8a525ff85727",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Elevacion lateral polea",
                    Range = "amplio",
                    Sensor = "muñeca",
                    UrlVideo = "https://www.youtube.com/watch?v=quAPSmsOzNk"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Maquina crunch",
                    Range = "corto ",
                    Sensor = "?",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=o_0WrejFbAw&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=14"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Máquina oblicuos",
                    Range = "corto ",
                    Sensor = "?",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ElDIvayj3oI&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=4"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Crunch normal",
                    Range = "corto ",
                    Sensor = "?"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Crunch laterales",
                    Range = "corto	",
                    Sensor = "?"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Isometrico frontal",
                    Range = "estatico",
                    Sensor = "?"
                },
                new SubWorkoutModel
                {
                    ParentId = "f617be8e-c751-44e5-94d1-48b6d35ac41c",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Isometrico lateral",
                    Range = "estatico",
                    Sensor = "?"
                },
                new SubWorkoutModel
                {
                    ParentId = "d4a54072-891b-44e6-bd1f-8bdb8251d65a",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Maquina aperture gluteos",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=Ld0qWunNpco&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=6  "
                },
                new SubWorkoutModel
                {
                    ParentId = "d4a54072-891b-44e6-bd1f-8bdb8251d65a",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Maquina patada de gluteos",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ErLphmV-y60&index=21&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX "
                },
                new SubWorkoutModel
                {
                    ParentId = "d4a54072-891b-44e6-bd1f-8bdb8251d65a",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Lounge",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=L8fvypPrzzs&list=PLBrgqsGCyn2xQVBgDaemdoK8TJlgSpX0G&index=63 "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Back squat peso libre",
                    Range = "amplio",
                    Sensor = "pierna ",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ultWZbUMPL8&index=3&list=PLBrgqsGCyn2xQVBgDaemdoK8TJlgSpX0G  "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Front squat peso libre",
                    Range = "amplio",
                    Sensor = "pierna ",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=m4ytaCJZpl0&index=2&list=PLBrgqsGCyn2xQVBgDaemdoK8TJlgSpX0G  "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Air squat",
                    Range = "amplio",
                    Sensor = "pierna ",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=C_VtOYc6j5c&list=PLBrgqsGCyn2xQVBgDaemdoK8TJlgSpX0G          "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Back squat guiado",
                    Range = "amplio",
                    Sensor = "pierna ",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=qPWXdq7idrI                                                  "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Leg curl machine",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=x7PRWgaZyYw&index=1&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX  "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Leg press machine",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=ZyWFzGyFwK0&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=10 "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Seated leg press",
                    Range = "amplio",
                    Sensor = "pierna ",
                    UrlVideo =
                        "https://www.youtube.com/watch?v=JYWuwV8oxlw&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX&index=2  "
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Premsa discos",
                    Range = "amplio",
                    Sensor = "pierna"
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Isquitibial tumbado",
                    Range = "amplio",
                    Sensor = "tobillo",
                    UrlVideo =
                        " https://www.youtube.com/watch?v=OZdDbL_1nd8&index=9&list=PLBy4FXpRwvuX-UNN3dztZ1X2tApS_GDbX"
                },
                new SubWorkoutModel
                {
                    ParentId = "4af3faec-b737-4b38-978b-8bc70bc03304",
                    Id = Guid.NewGuid().ToString(),
                    Description = "Gemelos màquina",
                    Range = "Corto ",
                    Sensor = "tobillo"
                }

            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(SubWorkoutModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(SubWorkoutModel item)
        {
            var _item = items.Where((SubWorkoutModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(SubWorkoutModel item)
        {
            var _item = items.Where((SubWorkoutModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<SubWorkoutModel> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<SubWorkoutModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<IEnumerable<SubWorkoutModel>> GetItemsFromParentIdAsync(string parentId)
        {
            return await Task.FromResult(items.Where(s => s.ParentId == parentId));
        }

        public Task<List<T>> Get<T>(string urlBase, string servicePrefix, string controller)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Put<T>(string urlBase, string servicePrefix, string controller, T model)
        {
            throw new NotImplementedException();
        }
    }

    public class MockTrainingPlanDataStore : IDataStore<TrainingPlanModel>
    {
        List<TrainingPlanModel> items;

        public MockTrainingPlanDataStore()
        {
            items = new List<TrainingPlanModel>();

            var mockItems = new List<TrainingPlanModel>
            {
                new TrainingPlanModel { Id = Guid.NewGuid().ToString(), Description = "Perdida de peso",  NumberOfDays = 6 },
                new TrainingPlanModel { Id = Guid.NewGuid().ToString(), Description = "Tonificación global",  NumberOfDays = 6 },
                new TrainingPlanModel { Id = Guid.NewGuid().ToString(), Description = "Aumento de masa muscular",  NumberOfDays = 6 },
                new TrainingPlanModel { Id = Guid.NewGuid().ToString(), Description = "Tonificacion de piernas",  NumberOfDays = 3 },
                new TrainingPlanModel { Id = Guid.NewGuid().ToString(), Description = "Tonificación de dorso/espalda",  NumberOfDays = 3 },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public Task<bool> AddItemAsync(TrainingPlanModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(TrainingPlanModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(TrainingPlanModel item)
        {
            throw new NotImplementedException();
        }

        public Task<TrainingPlanModel> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingPlanModel>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TrainingPlanModel>> GetItemsFromParentIdAsync(string id)
        {
            return await Task.FromResult(items.Where(s => s.Id == id));
        }

        public Task<List<T>> Get<T>(string urlBase, string servicePrefix, string controller)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Put<T>(string urlBase, string servicePrefix, string controller, T model)
        {
            throw new NotImplementedException();
        }
    }
}