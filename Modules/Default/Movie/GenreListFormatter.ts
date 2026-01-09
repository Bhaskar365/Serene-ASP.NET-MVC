namespace Serene1.Default { // Ensure this matches your project namespace

    @Serenity.Decorators.registerFormatter()
    export class GenreListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {

            let idList = ctx.value as number[];
            if (!idList || !idList.length)
                return "";

            // Access the lookup via the global Q helper
            let lookup = Q.getLookup<GenreRow>('Default.Genre');
            let byId = lookup.itemById;

            if (byId) {
                return idList.map(x => {
                    let g = byId[x];
                    return Q.htmlEncode(g ? g.Name : x);
                }).join(", ");
            }

            return "";
        }
    }
}