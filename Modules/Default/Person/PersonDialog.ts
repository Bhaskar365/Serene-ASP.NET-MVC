
namespace Serene1.Default {

    @Serenity.Decorators.registerClass()
    export class PersonDialog extends Serenity.EntityDialog<PersonRow, any> {
        protected getFormKey() { return PersonForm.formKey; }
        protected getIdProperty() { return PersonRow.idProperty; }
        protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
        protected getNameProperty() { return PersonRow.nameProperty; }
        protected getService() { return PersonService.baseUrl; }
        protected getDeletePermission() { return PersonRow.deletePermission; }
        protected getInsertPermission() { return PersonRow.insertPermission; }
        protected getUpdatePermission() { return PersonRow.updatePermission; }
        /*protected getRowDefinition() { return PersonRow; }*/

        protected form = new PersonForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            this.form.MoviesGrid.personId = this.entityId;
        }

    }
}