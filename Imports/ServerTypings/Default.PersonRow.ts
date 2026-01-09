namespace Serene1.Default {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        LastName?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Height?: number;
        Gender?: Gender;
        FullName?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FirstName';
        export const localTextPrefix = 'Default.Person';
        export const lookupKey = 'Default.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('Default.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            LastName = "LastName",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Height = "Height",
            Gender = "Gender",
            FullName = "FullName"
        }
    }
}

