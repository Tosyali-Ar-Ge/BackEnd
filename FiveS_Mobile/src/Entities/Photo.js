class Photo {
    constructor(Id, CreatedDatetime, Detail, DocumentType, FileName,
        MimeType, QuestionREF, UserREF, AuditREF, FacilityREF) {
        this.Id = Id;
        this.CreatedDatetime = CreatedDatetime;
        this.Detail = Detail;
        this.DocumentType = DocumentType;
        this.FileName = FileName;
        this.MimeType = MimeType;
        this.QuestionREF = QuestionREF;
        this.UserREF = UserREF;
        this.AuditREF = AuditREF;
        this.FacilityREF = FacilityREF;
    }
}