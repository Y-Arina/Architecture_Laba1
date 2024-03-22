using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45.Managers.Doctors;
using Laba45.Managers.Hospitals;
using Laba45.Managers.Medical_Records;
using Laba45.Managers.Nurses;
using Laba45.Managers.Patients;
using Laba45.Managers.Receptions;
using Laba45.Managers.Sick_Lists;
using Laba45.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laba45.Controllers
{
    public class HospitalController : Controller
    {
        IHospitalManager _hospitalmanager;
        IDoctorManager _docmanager;
        IPatientManager _patmanager;
        ISickListManager _listmanager;
        IReceptionManager _recepmanager;
        IMedicalRecordManager _medmanager;
        INurseManager _nurmanager;
        public HospitalController(IHospitalManager _h,IDoctorManager _d,IPatientManager _p,ISickListManager _l,IReceptionManager _r,IMedicalRecordManager _m,INurseManager _n)
        {
            _hospitalmanager = _h;
            _docmanager = _d;
            _patmanager = _p;
            _listmanager = _l;
            _recepmanager = _r;
            _medmanager = _m;
            _nurmanager = _n;
        }
        
        public IActionResult MainPage()
        {
            return View();
        }
        //больница
        #region
        public IActionResult AddHospitals()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddHospitalsCreate(string NumberHospital, string adress, string numberphone, string starthours, string finishhours)
        {
            HospitalManagerClass _hospitals = new HospitalManagerClass(Convert.ToInt32(NumberHospital), adress, numberphone, starthours, finishhours);
            await _hospitalmanager.AddHospital(_hospitals);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintHospitals()
        {
            var entity = await _hospitalmanager.PrintHospital();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintHospital()
        {
            var entity = await _hospitalmanager.PrintHospital();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditHospital(Guid id)
        {
            var entity = await _hospitalmanager.EditHospital1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditHospital1(Guid id, string NumberHospital, string adress, string numberphone, string starthours, string finishhours)
        {
            HospitalManagerClass _hospitals = new HospitalManagerClass(Convert.ToInt32(NumberHospital), adress, numberphone, starthours, finishhours);
            await _hospitalmanager.EditHospital2(id, _hospitals);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async  Task<ActionResult> DeletePrintHospital()
        {
            var entity = await _hospitalmanager.PrintHospital();
            return View(entity);
        }
        public async Task<ActionResult> DeleteHospital(Guid Id)
        {
            await _hospitalmanager.DeleteHospital(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchHospital()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchHospital1(string NumberHospital, string Adress)
        {
            var entity = await _hospitalmanager.SearchHospital(Convert.ToInt32(NumberHospital), Adress);
            return View(entity);
        }
        #endregion
        //доктор
        #region
        [HttpGet]
        public async Task<ViewResult> AddDocPrintHospital()
        {
            var entity = await _hospitalmanager.PrintHospital();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddDoctor(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddDoctor2(string Id,string Surname, string Name, string Patronymic, string Profession, string CabinetNumber, string StartHour, string FinishHor)
        {
            DoctorManagerClass doc = new DoctorManagerClass(Guid.Parse(Id), Surname, Name, Patronymic, Profession, Convert.ToInt32(CabinetNumber), StartHour, FinishHor);
            await _docmanager.AddDoctor(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintDoctors()
        {
            var entity = await _docmanager.PrintDoctor();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintDoctor()
        {
            var entity = await _docmanager.PrintDoctor();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditDoctor(Guid id)
        {
            var entity = await _docmanager.EditDoctor1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditDoctor1(string Id, string Surname, string Name, string Patronymic, string Profession, string CabinetNumber, string StartHour, string FinishHor)
        {
            DoctorManagerClass doc = new DoctorManagerClass(Guid.Parse(Id), Surname, Name, Patronymic, Profession, Convert.ToInt32(CabinetNumber), StartHour, FinishHor);
            await _docmanager.EditDoctor2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintDoctor()
        {
            var entity = await _docmanager.PrintDoctor();
            return View(entity);
        }
        public async Task<ActionResult> DeleteDoctor(Guid Id)
        {
            await _docmanager.DeleteDoctor(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchDoctor()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchDoctor1(string Surname, string Nume)
        {
            var entity = await _docmanager.SearchDoctor(Surname,Nume);
            return View(entity);
        }
        #endregion
        //пациент
        #region
        [HttpGet]
        public async Task<ViewResult> AddPatientPrintDoc()
        {
            var entity = await _docmanager.PrintDoctor();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddPatient(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddPatient2(string Id, string Surname, string Name, string Patronymic)
        {
            PatientManagerClass doc = new PatientManagerClass(Guid.Parse(Id), Surname, Name, Patronymic);
            await _patmanager.AddPatient(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintPatients()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintPatient()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditPatient(Guid id)
        {
            var entity = await _patmanager.EditPatient1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditPatient1(string Id, string Surname, string Name, string Patronymic)
        {
            PatientManagerClass doc = new PatientManagerClass(Guid.Parse(Id), Surname, Name, Patronymic);
            await _patmanager.EditPatient2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintPatient()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        public async Task<ActionResult> DeletePatient(Guid Id)
        {
            await _patmanager.DeletePatient(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchPatient()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchPatient1(string Surname, string Name)
        {
            var entity = await _patmanager.SearchPatient(Surname, Name);
            return View(entity);
        }
        #endregion
        //больничный лист
        #region
        [HttpGet]
        public async Task<ViewResult> AddListtPrintPatient()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddList(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddList2(string Id, string PlaceWork, string StartDate, string FinishDate)
        {
            SickListManagerClass doc = new SickListManagerClass(Guid.Parse(Id), PlaceWork, Convert.ToDateTime(StartDate), Convert.ToDateTime(FinishDate));
            await _listmanager.AddSickList(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintList()
        {
            var entity = await _listmanager.PrintSickList();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintList()
        {
            var entity = await _listmanager.PrintSickList();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditList(Guid id)
        {
            var entity = await _listmanager.EditSickList1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditList1(string Id, string PlaceWork, string StartDate, string FinishDate)
        {
            SickListManagerClass doc = new SickListManagerClass(Guid.Parse(Id), PlaceWork, Convert.ToDateTime(StartDate), Convert.ToDateTime(FinishDate));
            await _listmanager.EditSickList2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintList()
        {
            var entity = await _listmanager.PrintSickList();
            return View(entity);
        }
        public async Task<ActionResult> DeleteList(Guid Id)
        {
            await _listmanager.DeleteStickList(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchList()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchList1(string StartDate, string FinishDate)
        {
            var entity = await _listmanager.SearchSickList(Convert.ToDateTime(StartDate), Convert.ToDateTime(FinishDate));
            return View(entity);
        }
        #endregion
        //талоны
        #region
        [HttpGet]
        public async Task<ViewResult> AddReceptionPrintPatient()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddReception(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddReception2(string Id, string Date, string Time)
        {
            ReceptionManagerClass doc = new ReceptionManagerClass(Guid.Parse(Id), Convert.ToDateTime(Date),Time);
            await _recepmanager.AddReceptin(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintReception()
        {
            var entity = await _recepmanager.PrintReception();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintReception()
        {
            var entity = await _recepmanager.PrintReception();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditReception(Guid id)
        {
            var entity = await _recepmanager.EditReception1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditReception1(string Id, string Date, string Time)
        {
            ReceptionManagerClass doc = new ReceptionManagerClass(Guid.Parse(Id), Convert.ToDateTime(Date), Time);
            await _recepmanager.EditReception2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintReception()
        {
            var entity = await _recepmanager.PrintReception();
            return View(entity);
        }
        public async Task<ActionResult> DeleteReception(Guid Id)
        {
            await _recepmanager.DeleteReception(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchReception()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchReception1(string Date, string Time)
        {
            var entity = await _recepmanager.SearchReception(Convert.ToDateTime(Date), Time);
            return View(entity);
        }
        #endregion
        //медицинская карта
        #region
        [HttpGet]
        public async Task<ViewResult> AddMedRecordPrintPatient()
        {
            var entity = await _patmanager.PrintPatient();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddMedRecord(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddMedRecord2(string Id, string NumberRecord, string Insurance_policy, string BirthDate, string NumberPhone, string Adress)
        {
            MedicalRecordManagerClass doc = new MedicalRecordManagerClass(Guid.Parse(Id), NumberRecord, Insurance_policy, Convert.ToDateTime(BirthDate), NumberPhone, Adress);
            await _medmanager.AddRecord(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintMedRecord()
        {
            var entity = await _medmanager.PrintRecord();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintMedRecord()
        {
            var entity = await _medmanager.PrintRecord();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditMedRecord(Guid id)
        {
            var entity = await _medmanager.EditRecord1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditMedRecord1(string Id, string NumberRecord, string Insurance_policy, string BirthDate, string NumberPhone, string Adress)
        {
            MedicalRecordManagerClass doc = new MedicalRecordManagerClass(Guid.Parse(Id), NumberRecord, Insurance_policy, Convert.ToDateTime(BirthDate), NumberPhone, Adress);
            await _medmanager.EditRecord2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintMedRecord()
        {
            var entity = await _medmanager.PrintRecord();
            return View(entity);
        }
        public async Task<ActionResult> DeleteMedRecord(Guid Id)
        {
            await _medmanager.DeleteRecord(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchMedRecord()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchMedRecord1(string Insurance_policy)
        {
            var entity = await _medmanager.SearchRecord(Insurance_policy);
            return View(entity);
        }
        #endregion
        //мед.сестра
        #region
        [HttpGet]
        public async Task<ViewResult> AddNursePrintDoc()
        {
            var entity = await _docmanager.PrintDoctor();
            return View(entity);
        }
        [HttpGet]
        public ActionResult AddNurse(Guid id)
        {
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddNurse2(string Id, string Surname, string Name, string Patronymic, string Profession)
        {
            NurseManagerClass doc = new NurseManagerClass(Guid.Parse(Id), Surname, Name, Patronymic, Profession);
            await _nurmanager.AddPNurse(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ViewResult> PrintNurse()
        {
            var entity = await _nurmanager.PrintNurse();
            return View(entity);
        }
        [HttpGet]
        public async Task<ViewResult> EditPrintNurse()
        {
            var entity = await _nurmanager.PrintNurse();
            return View(entity);
        }
        [HttpGet]
        public async Task<ActionResult> EditNurse(Guid id)
        {
            var entity = await _nurmanager.EditNurse1(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> EditNurse1(string Id, string Surname, string Name, string Patronymic, string Profession)
        {
            NurseManagerClass doc = new NurseManagerClass(Guid.Parse(Id), Surname, Name, Patronymic, Profession);
            await _nurmanager.EditNurse2(doc);
            return RedirectToAction(nameof(MainPage));
        }
        [HttpGet]
        public async Task<ActionResult> DeletePrintNurse()
        {
            var entity = await _nurmanager.PrintNurse();
            return View(entity);
        }
        public async Task<ActionResult> DeleteNurse(Guid Id)
        {
            await _nurmanager.DeleteNurse(Id);
            return RedirectToAction(nameof(MainPage));
        }
        public IActionResult SearchNurse()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> SearchNurse1(string Surname, string Name)
        {
            var entity = await _nurmanager.SearchNurse(Surname,Name);
            return View(entity);
        }
        #endregion
    }
}
