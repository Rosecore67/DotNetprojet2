# DotNetprojet2
Projet dans le cadre de la formation "Déboguez une application"

Introduction :

Il s'agit d'un projet de boutique en ligne de l'entreprise Lambazon.
Nos clients pourront passer par cette boutique pour effectuer leur achat.
Il s'agit d'une nouvelle plateforme utilisant ASP.NET Core.

Fonctionnalités :

Le client pourra faire les opérations suivantes :

- Accéder à la page d'accueil contenant les produits.
- Changer, au besoin, la langue sur le site.
- Ajouter les produits au panier.
- Supprimer les produits du panier si erreur.
- Passer commande après avoir renseigné ses informations.
- Le client pourra évoluer sur 3 pages différentes (L'accueil, le panier et la commande)

Configuration :

Pour configurer cette application, vous devez prendre en compte les aspects suivants :

    Localisation multilingue :
        Les langues prises en charge sont configurées dans la méthode ConfigureServices(). Les langues disponibles incluent l'anglais (GB et US), le français et l'espagnol.
        La langue par défaut est l'anglais (GB).
        Les formats de nombres, de dates, etc. sont configurés en fonction des cultures prises en charge.

    Session utilisateur :
        L'application utilise une session pour stocker les données temporaires de l'utilisateur. Cette fonctionnalité est activée dans la méthode ConfigureServices() en appelant AddSession().
        Ass

Assurez-vous d'ajouter UseSession() dans la méthode Configure() pour activer la session pour les requêtes HTTP.

    Fichiers statiques :
        Les fichiers statiques, tels que les images, les fichiers CSS et JavaScript, sont servis à partir du répertoire wwwroot de l'application. Assurez-vous d'utiliser UseStaticFiles() dans la méthode Configure() pour activer le service des fichiers statiques.

    Localisation de l'interface utilisateur :
        Les fichiers de ressources localisées sont stockés dans le répertoire "Resources". L'application prend en charge la localisation des vues en ajoutant AddViewLocalization() et AddDataAnnotationsLocalization() lors de la configuration de MVC dans ConfigureServices().

    Routing des requêtes HTTP :
        Le routing des requêtes HTTP est configuré pour diriger les requêtes vers les contrôleurs et actions appropriés. Par défaut, les requêtes sont dirigées vers le contrôleur "Product" et l'action "Index". Cette configuration est définie dans la méthode Configure() en utilisant UseMvc().

En suivant ces instructions de configuration, vous pourrez déployer et exécuter l'application avec les paramètres appropriés pour une expérience utilisateur optimale.

Contributions :

Si vous constatez des bugs ou nous soummettre vos propositions,
veuillez contacter l'équipe en charge du projet à l'adresse mail suivante : "Lambazon@exemple.mail".