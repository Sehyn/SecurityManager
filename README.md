## # SecurityManager
Security Manager est un programme développé pour effectuer certaines manipulations dans le cadre du service d'agent de sécurité. Etant mon emploi à temps plein (SSIAP 1) et ayant pu voir diverses main courantes électroniques ainsi que les services de pointages, plannings, evénements et autres. J'ai décidé de développer ma propre application dans le but de la commercialiser dans le futur éventuellement mais SURTOUT pour en apprendre plus sur le C#.
Le programme stock les données 100% Localement ce qui est très risqué dans le domaine de la sécurité, mais les héberger en ligne églamment est une faille de sécurité a voir..

PROJET A L'ABANDON A CAUSE DE @https://github.com/EvannG1?tab=repositories [Pas le temps pour ton api de merde 3500€ pour le faire]

**Plusieurs fonctionalités seront ajoutées au fil du temps.**

## A faire :

- [ ] Pouvoir modifier les consignes via une page web pour le client (api?) @EvannG1 (https://github.com/EvannG1?tab=repositories)
- [ ] Animation quand on ferme une form
- [ ] Système mise à jour
- [ ] Logger les les prises de service avec tableau via SQL
- [ ] Rénitialisation logiciel
- [ ] Utilisation de #region pour meilleur lecture et organisation
- [ ] Optimiser le code notamment l'utilisation de fonctions asynchromes ! (await/task.delay) * J'ai fait n'importe quoi !
- [ ] Créer un répertoire d'agent en listview ? (ou il est possible d'y ajouter des informations selon le niveau d'accès)
- [ ] Rendre le répertoire d'agent modifiable selon le niveau de l'utilisateur connecté
- [ ] Faire en sorte que quand on utilise l'Hotkey (CTRL + F3) au setup/start up du programme ça arrete l'opération en cours
- [ ] Pouvoir envoyer des rapports directement par mail
- [ ] Pouvoir utiliser autre chose que des .txt pour la main courante, etc.. (Idée PDF + design mais aucune idée de comment faire!)



## Réalisé :

- [x] Design Setup
- [x] Design Connexion
- [x] Design Utilisateur
- [x] Design Centre Aide
- [x] Design Notification
- [x] Système de catch exception-
- [x] Logger automatiquement une erreur dans un fichier texte avec DATE(dd/mm/yyy) + timestamp et exception ex.message
- [x] Renommer chaque form, classe et designers items correctement 
- [x] Utiliser les commentaires pragma pour les placeholders
- [x] Ecrire dans la main courante et l'ouvrir sur une textbox
- [x] Ne pas créer pleins de formes utiliser un tab/panel ou meme form en utilisant visible = false/true 
- [x] Syutème de connexion (Utilisation d'une DB via MySQL Studio) (LOCAL)
- [x] Régler le problème pour la FrmNotification apparait dans la taskbar.

## Developpé par :
* Sehyn

## Credits : 
* Guna/Siticone Library for UI (payant).



## Informations :
* Merci d'avoir téléchargé le code source.
* Je suis développeur par passion et non pas par métier je suis débutant.
* Le code peut être vraiment pas propre, je m'en excuse n'hésitez pas a le corriger.
* Le code n'est pas fini, beaucoup d'optimisations sont a faire.
* Je recherche activement de l'aide pour développer ce programme qui me tient à coeur.
* Mon Discord: Sehyn#1337

A ignorer pense bete: 

- [ ] En sorte de trier les informations selon le site d'execution (explications: le programme est actuellement designé comme si nous etions dans un centre commercial, cependant si le programme viendrait à etre utilisé sur un chantier par exemple retrouver ces informations via...



